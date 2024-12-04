
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using EFCore.BulkExtensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using SelfPortalAPi.Model;

//using SelfPortalAPi.Model;
using SelfPortalAPi.Models;
using SelfPortalAPi.Models.Vm;

namespace SelfPortalAPi.UnitOfWork;
public interface IPhaseIIRepo
{
    Task<Dictionary<string, object>> GetAllBusinessesAsync(int pageNumber, int pageSize, string busName, string tx_cm, bool IsAdmin);
    Task<ReturnObject> SyncAssetAsync();
    Task<ReturnObject> AllUsers(int pageNumber, int pageSize, string? searchTerm, string? username);
    Task<ReturnObject> UpdateAdmin(int userTypeId, int userId, bool status, int roleId);
    Task<ReturnObject> SycnCooperate();
    Task<ReturnObject> SycnAssessmentItems();
    Task<ReturnObject> SycnAssessmentRules();
    Task<Dictionary<List<ReturnEmployeeMon>, int>> getallEmployeesCount(int pageNumber, int pageSize, string busName, string tx_cm, bool IsAdmin);
    Task<List<EmployeeIncomeVm>> GetEmployeeIncomeView(EmployeesViewFmModel emp);
    Task<List<EmployeesMonthlyIncome>> GetMonthlyIncomeAsync(EmpSchedule obj);
    Task<List<EmployeesMonthlyIncome>> GetEmployeeMonthlyIncomeAsync(EmpSchedule obj);
    Task<List<EmpScheduleDetails>> CalculateMonthScheduleAsync(EmpSchedule empSch);
    Task<ReturnObject> Login(AdminSignUp adminSign);
    Task<Dictionary<IQueryable<Models.AssetTaxPayerDetailsApi>, int>> GetCompanyTiedToAdminUser(string tx_cm, bool det, int pgNo, int pgSize);
    int CalculateMonthsLeft(string monthName);
    decimal CalculateTax(decimal ch_income, decimal gross);
    Task<List<ScheduleGetViewRes>> GetSchedulesViewAsync(EmpSchFm empSch);
    Task<List<AssessmentRDMRes>> GetAssessmentRDMAsync(BusSchFm1 obj);
    Task<List<Models.AssetTaxPayerDetailsApi>> GetBusinessDetails(string BusinessRin, string CompanyRin);
    Task<List<EmployeesMonthlySchedule>> GetAssessmentSchudeleDetails(EmpMtAss ass);
    Task<List<EmployeesMonthlySchedule>> GetAssessmentScheduleDetails2(EmpMtAssNew ass);
    Task<List<EmployeesMonthlySchedule>> GetAssessmentSchudeleDetailsDownLoad(EmpMtAssForPdf ass);
}

public class PhaseIIRepo : IPhaseIIRepo
{
    private readonly SelfServiceConnect _dbContext;
    private readonly SelfServiceConnect _repo;
    private readonly IOptions<ConnectionStrings> _serviceSettings;
    public PhaseIIRepo(SelfServiceConnect dbContext, IOptions<ConnectionStrings> serviceSettings, SelfServiceConnect repo)
    {
        _dbContext = dbContext;
        _serviceSettings = serviceSettings;
        _repo = repo;
    }
    public async Task<Dictionary<string, object>> GetAllBusinessesAsync(int pageNumber, int pageSize, string busName, string tx_cm, bool IsAdmin)
    {
        int totalCount = 0;
        IQueryable<BusinessVm> query = null;
        var pageRes = new List<BusinessVm>();

        var bigQuery = (from a in _dbContext.AssetTaxPayerDetailsApis
                        join b in _dbContext.CompanyListApis
                        on a.TaxPayerRinnumber equals b.TaxPayerRin
                        select new BusinessVm
                        {
                            CompanyName = a.TaxPayerName,
                            BusinessRin = a.AssetRin,
                            BusinessName = a.AssetName,
                            CompanyRin = a.TaxPayerRinnumber,
                            LgaName = a.AssetAddress,
                            TaxOffice = b.TaxOffice
                        });

        if (!string.IsNullOrEmpty(busName))
        {
            switch (IsAdmin)
            {
                case true:
                    query = bigQuery.Where(o => o.TaxOffice.ToLower().Trim() == tx_cm.ToLower().Trim()
                                             && o.BusinessName.ToLower().Trim() == busName.ToLower().Trim());
                    break;
                case false:
                    query = bigQuery.Where(o => o.CompanyRin.ToLower().Trim() == tx_cm.ToLower().Trim()
                                             && o.BusinessName.ToLower().Trim() == busName.ToLower().Trim());
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (IsAdmin)
            {
                case true:
                    query = bigQuery.Where(o => o.TaxOffice.ToLower().Trim() == tx_cm.ToLower().Trim());
                    break;
                case false:
                    query = bigQuery.Where(o => o.CompanyRin.ToLower().Trim() == tx_cm.ToLower().Trim());
                    break;
                default:
                    break;
            }
        }

        if (query != null)
        {
            pageRes = await query.ToListAsync();

            pageRes = pageRes.DistinctBy(o => o.BusinessName).ToList();
            totalCount = query.Count();
            if (pageNumber != 0 && pageSize != 0)
            {
                pageRes = pageRes
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
            else
                pageRes = pageRes.ToList();
        }

        return new Dictionary<string, object>
{
    { "Businesses", pageRes },
    { "TotalCount", totalCount }
};
    }
    public async Task<Dictionary<List<ReturnEmployeeMon>, int>> getallEmployeesCount(int pageNumber, int pageSize, string busName, string tx_cm, bool IsAdmin)
    {
        IDictionary<IQueryable<Models.AssetTaxPayerDetailsApi>, int> busDetail;
        string query = "";
        IQueryable<string>? list;
        if (string.IsNullOrEmpty(busName))
        {
            if (IsAdmin)
            {
                busDetail = await GetCompanyTiedToAdminUser(tx_cm, true, pageNumber, pageSize);
                query = @$"
            SELECT 
                c.TaxPayerID as CompanyId,
                a.assetid as businessid,
                c.TaxPayerName as CompanyName,
                COUNT(e.EmployeeId) AS NoOfEmployees,
                c.TaxPayerRIN as CompanyRin,
                a.AssetName as businessName,
                a.AssetRIN as businessRin,
                a.AssetAddress as businessAddress,
                a.AssetLGA as businessLga,
                c.TaxOffice
            FROM 
                AssetTaxPayerDetails_API a
            LEFT JOIN 
                EmployeesMonthlyIncome e ON a.AssetID = e.BusinessId AND e.CompanyId = a.TaxPayerID
            LEFT JOIN 
                CompanyList_API c ON a.TaxPayerRINNumber = c.TaxPayerRIN
            WHERE 
                a.TaxPayerRINNumber IN ({string.Join(", ", busDetail.Select(r => $"'{r.Key.FirstOrDefault().TaxPayerRinnumber}'"))})
            GROUP BY 
                c.TaxPayerID, a.AssetID, c.TaxPayerName, c.TaxPayerRIN, a.AssetName, a.AssetRIN, a.AssetAddress, a.AssetLGA, c.TaxOffice";
            }
            else
            {
                // For non-admin users
                string cm = "";
                busDetail = await GetCompanyTiedToAdminUser(tx_cm, false, pageNumber, pageSize);
                cm = busDetail.FirstOrDefault().Key.FirstOrDefault().TaxPayerRinnumber;
                query = @$"
            SELECT 
                c.TaxPayerID as CompanyId,
                a.assetid as businessid,
                c.TaxPayerName as CompanyName,
                COUNT(e.EmployeeId) AS NoOfEmployees,
                c.TaxPayerRIN as CompanyRin,
                a.AssetName as businessName,
                a.AssetRIN as businessRin,
                a.AssetAddress as businessAddress,
                a.AssetLGA as businessLga,
                c.TaxOffice
            FROM 
                AssetTaxPayerDetails_API a
            LEFT JOIN 
                EmployeesMonthlyIncome e ON a.AssetID = e.BusinessId AND e.CompanyId = a.TaxPayerID
            LEFT JOIN 
                CompanyList_API c ON a.TaxPayerRINNumber = c.TaxPayerRIN
            WHERE 
                a.TaxPayerRINNumber = '{cm}'
            GROUP BY 
                c.TaxPayerID, a.AssetID, c.TaxPayerName, c.TaxPayerRIN, a.AssetName, a.AssetRIN, a.AssetAddress, a.AssetLGA, c.TaxOffice";
            }
        }
        else
        {
            busDetail = await GetCompanyTiedToAdminUser(tx_cm, false, pageNumber, pageSize);
            query = @$"
            SELECT 
                c.TaxPayerID as CompanyId,
                a.assetid as businessid,
                c.TaxPayerName as CompanyName,
                COUNT(e.EmployeeId) AS NoOfEmployees,
                c.TaxPayerRIN as CompanyRin,
                a.AssetName as businessName,
                a.AssetRIN as businessRin,
                a.AssetAddress as businessAddress,
                a.AssetLGA as businessLga,
                c.TaxOffice
            FROM 
                AssetTaxPayerDetails_API a
            LEFT JOIN 
                EmployeesMonthlyIncome e ON a.AssetID = e.BusinessId AND e.CompanyId = a.TaxPayerID
            LEFT JOIN 
                CompanyList_API c ON a.TaxPayerRINNumber = c.TaxPayerRIN
            WHERE 
                a.TaxPayerName = '{busName}' or a.AssetName = '{busName}'
            GROUP BY 
                c.TaxPayerID, a.AssetID, c.TaxPayerName, c.TaxPayerRIN, a.AssetName, a.AssetRIN, a.AssetAddress, a.AssetLGA, c.TaxOffice";

        }
        var pageRes = await _dbContext.Set<ReturnEmployeeMon>()
            .FromSqlRaw(query) 
            .ToListAsync();

        int totalCount = busDetail.FirstOrDefault().Value;

        // If no results found, return a default empty result
        if (!pageRes.Any())
        {
            var bDetail = busDetail.FirstOrDefault().Key.FirstOrDefault();
            ReturnEmployeeMon bvnm = new ReturnEmployeeMon
            {
                NoOfEmployees = 0,
                businessAddress = bDetail?.AssetAddress,
                businessLga = bDetail?.AssetLga,
                businessName = bDetail?.AssetName,
                businessRin = bDetail?.AssetRin,
                CompanyId = bDetail?.TaxPayerId,
                businessId = bDetail?.AssetId,
                CompanyName = bDetail?.TaxPayerName,
                CompanyRin = bDetail?.TaxPayerRinnumber
            };
            pageRes.Add(bvnm);
            totalCount = 1;
        }

        return new Dictionary<List<ReturnEmployeeMon>, int> {
    { pageRes, totalCount }
};
    }
    public async Task<List<EmployeeIncomeVm>> GetEmployeeIncomeView(EmployeesViewFmModel emp)
    {
        var result = from i in _dbContext.Individuals
                     join e in _dbContext.EmployeesMonthlyIncomes on i.EmployeeId equals e.EmployeeId into joined
                     from e in joined.DefaultIfEmpty()
                     where e.BusinessId == emp.BusinessId && e.CompanyId == emp.CompanyId
                     group new { i, e } by new
                     {
                         i.EmployeeId,
                         i.Firstname,
                         i.Surname,
                         i.EmployeeRin,
                         e.Status
                     } into g
                     select new EmployeeIncomeVm
                     {
                         EmployeeId = g.Key.EmployeeId,
                         EmployeeRin = g.Key.EmployeeRin,
                         FullName = g.Key.Firstname + " " + g.Key.Surname,
                         TotalIncome = (decimal)g.Sum(x =>
                             (x.e.Basic ?? 0m) + (x.e.Rent ?? 0m) + (x.e.Transport ?? 0m) +
                             (x.e.Ltg ?? 0m) + (x.e.Utility ?? 0m) + (x.e.Meal ?? 0m) +
                             (x.e.Others ?? 0m) + (x.e.Nhf ?? 0m) + (x.e.Nhis ?? 0m) +
                             (x.e.Pension ?? 0m) + (x.e.LifeAssurance ?? 0m)
                         ),
                         Non_TaxableIncome = (decimal)g.Sum(x =>
                             (x.e.Pension ?? 0m) + (x.e.Nhf ?? 0m) + (x.e.Nhis ?? 0m) +
                             (x.e.LifeAssurance ?? 0m)
                         ),
                         GrossIncome = (decimal)g.Sum(x =>
                             ((x.e.Basic ?? 0m) + (x.e.Rent ?? 0m) + (x.e.Transport ?? 0m) +
                             (x.e.Ltg ?? 0m) + (x.e.Utility ?? 0m) + (x.e.Meal ?? 0m) +
                             (x.e.Others ?? 0m) + (x.e.Nhf ?? 0m) + (x.e.Nhis ?? 0m) +
                             (x.e.Pension ?? 0m) + (x.e.LifeAssurance ?? 0m))
                             -
                             ((x.e.Pension ?? 0m) + (x.e.Nhf ?? 0m) + (x.e.Nhis ?? 0m) +
                             (x.e.LifeAssurance ?? 0m))
                         ),
                         Status = g.Key.Status == true ? "Active" : "Inactive"
                     };


        return await result.ToListAsync();
    }

    public async Task<List<EmployeesMonthlyIncome>> GetMonthlyIncomeAsync(EmpSchedule obj)
    {

        return await _dbContext.EmployeesMonthlyIncomes
                            .Where(e => e.BusinessId == obj.BusinessId &&
                            e.CompanyId == obj.Companyid)
                            .ToListAsync();
    }
    public async Task<List<EmployeesMonthlyIncome>> GetEmployeeMonthlyIncomeAsync(EmpSchedule obj)
    {
        return await _dbContext.EmployeesMonthlyIncomes
                            .Where(e => e.BusinessId == obj.BusinessId &&
                            e.CompanyId == obj.Companyid)
                            .ToListAsync();
    }
    public int CalculateMonthsLeft(string monthName)
    {
        if (string.IsNullOrEmpty(monthName))
        {
            return 0;
        }
        string[] allMonths = new string[]
        {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
        };

        // Convert the month name to title case for case-insensitive comparison
        string inputMonth = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthName.ToLower());

        int currentMonthIndex = Array.IndexOf(allMonths, inputMonth);

        if (currentMonthIndex == -1)
        {
            return -1;
        }

        int monthsLeft = 12 - currentMonthIndex - 1; // Subtract 1 to exclude the current month
        return monthsLeft;
    }
    public async Task<List<EmpScheduleDetails>> CalculateMonthScheduleAsync(EmpSchedule empSch)
    {
        var result =
            from e in _dbContext.EmployeesMonthlyIncomes
            where e.BusinessId == empSch.BusinessId &&
                  e.CompanyId == empSch.Companyid
            group e by new
            {
                e.Status
            } into g
            select new
            {
                TotalIncome = g.Sum(x => x.Basic + x.Rent + x.Transport + x.Ltg + x.Utility + x.Meal + x.Others + x.Nhf + x.Nhis + x.Pension + x.LifeAssurance),
                NonTaxableIncome = g.Sum(x => x.Pension + x.Nhf + x.Nhis + x.LifeAssurance),
                GrossIncome = g.Sum(x => (x.Basic + x.Rent + x.Transport + x.Ltg + x.Utility + x.Meal + x.Others + x.Nhf + x.Nhis + x.Pension + x.LifeAssurance) - (x.Pension + x.Nhf + x.Nhis + x.LifeAssurance)),
                Status = (bool)g.Key.Status ? "Active" : "Inactive"
            };

        var scheduleDetailsList = new List<EmpScheduleDetails>();

        foreach (var item in result)
        {
            double cc = 16666.66667;
            decimal CcValue = (decimal)cc;
            decimal cra = (decimal)(((item.GrossIncome * 20) / 100) + CcValue);
            decimal taxFreePay = (decimal)(cra + item.NonTaxableIncome);
            decimal chargeableIncome = (decimal)(item.TotalIncome - taxFreePay);

            var empScheduleDetails = new EmpScheduleDetails
            {
                TotalIncome = (decimal)item.TotalIncome,
                NonTaxableIncome = (decimal)item.NonTaxableIncome,
                GrossIncome = (decimal)item.GrossIncome,
                Cra = cra,
                Tfp = taxFreePay,
                Ci = chargeableIncome,
                Tax = CalculateTax(chargeableIncome, (decimal)item.GrossIncome)
            };

            scheduleDetailsList.Add(empScheduleDetails);
        }

        return scheduleDetailsList;
    }
    public decimal CalculateTax(decimal ch_income, decimal gross)
    {
        double ci = 91666.66667;
        double ci2 = 133333.3333;
        double ci3 = 266666.6667;
        double cM = 0.7;
        double cM2 = 0.11;
        double cM3 = 0.15;
        double cM4 = 0.19;
        double cM5 = 0.21;
        double cM6 = 0.24;
        double cx = 18666.66667;
        double cx2 = 46666.66667;
        Decimal CcValue = (decimal)ci;
        Decimal CcValue2 = (decimal)ci2;
        Decimal CcValue3 = (decimal)ci3;
        Decimal CmValue = (decimal)cM;
        Decimal CmValue2 = (decimal)cM2;
        Decimal CmValue3 = (decimal)cM3;
        Decimal CmValue4 = (decimal)cM4;
        Decimal CmValue5 = (decimal)cM5;
        Decimal CmValue6 = (decimal)cM6;
        Decimal CxValue = (decimal)cx;
        Decimal CxValue2 = (decimal)cx2;

        decimal calc_tax = 0;
        decimal min_tax = (gross * 1) / 100;
        decimal finaltax = 0;

        if (ch_income <= 0)
        {
            calc_tax = min_tax;
        }
        else if (ch_income <= 25000)
        {
            calc_tax = ch_income * CmValue;
        }
        else if (ch_income <= 50000)
        {
            calc_tax = ((ch_income - 25000) * CmValue2) + 1750;
        }
        else if (ch_income <= CcValue)
        {
            calc_tax = ((ch_income - 50000) * CmValue3) + 4500;
        }
        else if (ch_income <= CcValue2)
        {
            calc_tax = ((ch_income - CcValue) * CmValue4) + 10750;
        }
        else if (ch_income <= CcValue3)
        {
            calc_tax = ((ch_income - CcValue2) * CmValue5) + CxValue;
        }
        else
        {
            calc_tax = ((ch_income - CcValue3) * CmValue6) + CxValue2;
        }

        finaltax = Math.Max(calc_tax, min_tax);
        return finaltax;
    }

    public async Task<List<ScheduleGetViewRes>> GetSchedulesViewAsync(EmpSchFm empSch)
    {
        var result = (from s in _dbContext.EmployeesMonthlySchedules
                      join i in _dbContext.Individuals on s.EmployeeRin equals i.EmployeeRin into si
                      from i in si.DefaultIfEmpty()
                      where s.BusinessId == empSch.BusinessId &&
                            s.EmployerId == empSch.Companyid
                      group new { i, s } by new
                      {

                          i.Firstname,
                          i.Surname,
                          i.Othername,
                          i.EmployeeRin,

                      } into g
                      select new
                      {
                          EmployeeRin = g.Key.EmployeeRin,
                          EmployeeName = g.Key.Firstname + " " + g.Key.Surname + " " + g.Key.Othername,
                          TotalIncome = g.Sum(x => x.s.Basic + x.s.Rent + x.s.Transport + x.s.OtherIncome + x.s.Nhf + x.s.Nhis + x.s.Pension + x.s.LifeAssurance),
                          NonTaxableIncome = g.Sum(x => x.s.Pension + x.s.Nhf + x.s.Nhis + x.s.LifeAssurance),
                          GrossIncome = g.Sum(x => (x.s.Basic + x.s.Rent + x.s.Transport + x.s.OtherIncome + x.s.Nhf + x.s.Nhis + x.s.Pension + x.s.LifeAssurance) - (x.s.Pension + x.s.Nhf + x.s.Nhis + x.s.LifeAssurance)),
                      }).ToList();

        var scheduleDetailsList = new List<ScheduleGetViewRes>();

        foreach (var item in result)
        {
            decimal cra = (decimal)(((item.GrossIncome * 20) / 100) + 200000);
            decimal taxFreePay = (decimal)(cra + item.NonTaxableIncome);
            decimal chargeableIncome = (decimal)(item.TotalIncome - taxFreePay);

            var empScheduleDetails = new ScheduleGetViewRes
            {
                EmployeeRin = item.EmployeeRin,
                EmployeeName = item.EmployeeName,
                TotalIncome = item.TotalIncome,
                GrossIncome = item.GrossIncome,
                NonTaxableIncome = item.NonTaxableIncome,
                CRA = cra,
                TaxFreePay = taxFreePay,
                ChargableIncome = chargeableIncome,
                MonthlyTax = CalculateTax(chargeableIncome, (decimal)item.GrossIncome)
            };

            scheduleDetailsList.Add(empScheduleDetails);
        }

        return await Task.FromResult(scheduleDetailsList);
    }

    public async Task<List<AssessmentRDMRes>> GetAssessmentRDMAsync(BusSchFm1 obj)
    {

        var query = from s in _dbContext.EmployeesMonthlySchedules
                    join a in _dbContext.AssetTaxPayerDetailsApis on new { s.BusinessId, s.EmployerId } equals new { BusinessId = a.AssetId.ToString(), EmployerId = a.TaxPayerId.ToString() } into sa
                    from a in sa.DefaultIfEmpty()
                    where s.BusinessId == obj.BusinessId && s.EmployerId == obj.CompanyId && s.AssessementStatusId == 1 && obj.TaxMonth == s.TaxMonth && obj.TaxYear == s.TaxYear
                    group s by new
                    {
                        a.TaxPayerTypeId,
                        a.TaxPayerId,
                        a.AssetTypeId,
                        a.AssetId,
                        s.BusinessId,
                        s.TaxYear
                    } into g
                    select new
                    {
                        g.Key.TaxPayerTypeId,
                        g.Key.TaxPayerId,
                        g.Key.AssetTypeId,
                        g.Key.AssetId,
                        g.Key.TaxYear,
                        TotalTax = g.Sum(x => x.Tax)
                    };

        var AaaAll = await query.ToListAsync();

        var AssRDM = new List<AssessmentRDMRes>();

        foreach (var item in AaaAll)
        {
            int monthId = GetMonthIdByName(obj.TaxMonth);
            var assessmentRulesQuery = from ar in _dbContext.AssessmentRules1
                                       where ar.TaxYear == obj.TaxYear && ar.TaxMonth.Equals(monthId)
                                       select new
                                       {
                                           Profile = ar.ProfileId,
                                           AssessmentRuleId = ar.AssessmentRuleId
                                       };

            var AssRules = await assessmentRulesQuery
                .Distinct()
                .ToListAsync();

            var assessmentItemsQuery = from ai in _dbContext.AssessmentItemApis
                                       where ai.AssessmentRuleName.Contains(obj.TaxMonth)
                                       select new
                                       {
                                           AssessmentItemID = ai.AssessmentItemId,
                                           TaxBaseAmount = ai.TaxBaseAmount
                                       };

            var AssItems = await assessmentItemsQuery
                .Distinct()
                .ToListAsync();

            if (AssRules.Any() && AssItems.Any())
            {
                var SchAss = new AssessmentRDMRes
                {
                    TaxPayerTypeID = item.TaxPayerTypeId,
                    TaxPayerID = item.TaxPayerId.ToString(),
                    AssetTypeID = item.AssetTypeId,
                    AssetID = item.AssetId,
                    Notes = "ssp",
                    TaxYear = item.TaxYear,
                    TaxBaseAmount = item.TotalTax,
                    ProfileID = AssRules.First().Profile,
                    AssessmentRuleID = AssRules.First().AssessmentRuleId,
                    LstAssessmentItem = AssItems.Select(ai => new AssessmentItemss
                    {
                        AssessmentItemID = AssItems.First().AssessmentItemID,
                        TaxBaseAmount = item.TotalTax
                    }).ToList()
                };

                AssRDM.Add(SchAss);
            }
        }

        return AssRDM;
    }

    public async Task<List<Models.AssetTaxPayerDetailsApi>> GetBusinessDetails(string BusinessRin, string CompanyRin)
    {
        var buss = await _dbContext.AssetTaxPayerDetailsApis
                 .Where(e => e.AssetRin == BusinessRin && e.TaxPayerRinnumber == CompanyRin)
                 .ToListAsync();
        return buss;
    }

    public async Task<List<EmployeesMonthlySchedule>> GetAssessmentSchudeleDetails(EmpMtAss ass)
    {
        var getId = await _dbContext.AssetTaxPayerDetailsApis.
                    FirstOrDefaultAsync(x => x.AssetRin == ass.BusinessRin && x.TaxPayerRinnumber == ass.CompanyRin);

        var buss = await _dbContext.EmployeesMonthlySchedules
            .Where(e => e.BusinessId == getId.AssetId.ToString() &&
                        e.EmployerId == getId.TaxPayerId.ToString() &&
                        e.TaxMonth == ass.TaxMonth &&
                        e.TaxYear == ass.TaxYear &&
                        e.AssessementStatusId == 2)
            .Select(e => new EmployeesMonthlySchedule
            {
                EmployeeRin = e.EmployeeRin,
                BusinessId = e.BusinessId,
                EmployerId = e.EmployerId,
                TaxMonth = e.TaxMonth,
                TaxYear = e.TaxYear
            })
            .ToListAsync();

        return buss;
    }

    public async Task<List<EmployeesMonthlySchedule>> GetAssessmentScheduleDetails2(EmpMtAssNew ass)
    {
        // Retrieve the asset and tax payer details
        var getId = await _dbContext.AssetTaxPayerDetailsApis
            .FirstOrDefaultAsync(x => x.AssetId.ToString() == ass.BusinessId && x.TaxPayerId.ToString() == ass.CompanyId);

        //if (getId == null)
        //{
        //    throw new System.Exception("Asset or Tax Payer details not found.");
        //}
        //var ret = _repo.UserManagements.FirstOrDefault(o => o.CompanyId.ToString() == ass.CompanyId);
        //if (ret == null)
        //{
        //    throw new System.Exception("Asset or Tax Payer details not found.");
        //}
        // Retrieve the employee monthly schedules
        var buss = await _dbContext.EmployeesMonthlySchedules
            .Where(e => e.BusinessId == ass.BusinessId.ToString() &&
                        e.EmployerId == ass.CompanyId &&
                        e.TaxMonth == ass.TaxMonth &&
                        e.TaxYear == ass.TaxYear)
            .ToListAsync();

        // Check assessment status
        if (buss.Any(e => e.AssessementStatusId == 2))
        {
            throw new System.Exception("Assessment Cannot Be Deleted Because It Is Already Approved. Use Re-Assess Option");
        }
        //else if (buss.Any(e => e.AssessementStatusId == 1))
        //{
        //    buss = buss.Select(e => new SelfPortalAPi.Models.EmployeesMonthlySchedule
        //    {
        //        EmployeeRin = getId.TaxPayerRinnumber,
        //        BusinessId = e.BusinessId,
        //        EmployerId = e.EmployerId,
        //        TaxMonth = e.TaxMonth,
        //        TaxYear = e.TaxYear ?? 0
        //    }).ToList();
        //}

        return buss;
    }
    private async Task<AssessmentResponse> StartApiHitsAssessmentItem(int pageNumber, int pageSize, int apiId)
    {
        JavaScriptSerializer js = new();
        string url = apiId switch
        {
            1 => $"{_serviceSettings.Value.ErasBaseUrl}SupplierData/PAYE_Collection_Multiple_Employees_BS_A_F_AssessmentItem?pageNumber={pageNumber}&pageSize={pageSize}",
            2 => $"{_serviceSettings.Value.ErasBaseUrl}SupplierData/PAYE_Collection_Multiple_Employees_BS_G_AssessmentItem?pageNumber={pageNumber}&pageSize={pageSize}",
            3 => $"{_serviceSettings.Value.ErasBaseUrl}SupplierData/PAYE_Collection_Multiple_Employees_BS_H_Z_AssessmentItem?pageNumber={pageNumber}&pageSize=10000",
            _ => ""
        };

        AllFunction al = new();
        string token = al.GetToken(
            _serviceSettings.Value.ErasBaseUrl,
            _serviceSettings.Value.eirsusername,
            _serviceSettings.Value.eirspassword
        );

        string response = await al.CallAPi(url, token, "get", "");
        AssessmentResponse? rootObjectVm = js.Deserialize<AssessmentResponse>(response);

        return rootObjectVm;
    }
    private async Task<AssessmentRuleResponse> StartApiHitsAssessmentRule(int pageNumber, int pageSize, int apiId)
    {
        JavaScriptSerializer js = new();
        string url = $"{_serviceSettings.Value.ErasBaseUrl}User/GetAssessentRules?pageNumber={pageNumber}&pageSize={pageSize}";


        AllFunction al = new();
        string token = al.GetToken(
            _serviceSettings.Value.ErasBaseUrl,
            _serviceSettings.Value.eirsusername,
            _serviceSettings.Value.eirspassword
        );

        string response = await al.CallAPi(url, token, "get", "");
        AssessmentRuleResponse? rootObjectVm = js.Deserialize<AssessmentRuleResponse>(response);

        return rootObjectVm;
    }
   
    private async Task<CorporateResponse> StartApiHitsCooperate(int pageNumber, int pageSize, int apiId)
    {
        JavaScriptSerializer js = new();
        string url = apiId switch
        {
            1 => $"{_serviceSettings.Value.ErasBaseUrl}SupplierData/PAYE_Collection_Multiple_Employees_BS_A_F_TaxPayer?pageNumber={pageNumber}&pageSize={pageSize}",
            2 => $"{_serviceSettings.Value.ErasBaseUrl}SupplierData/PAYE_Collection_Multiple_Employees_BS_G_TaxPayer?pageNumber={pageNumber}&pageSize={pageSize}",
            3 => $"{_serviceSettings.Value.ErasBaseUrl}SupplierData/PAYE_Collection_Multiple_Employees_BS_H_Z_TaxPayer?pageNumber={pageNumber}&pageSize=10000",
            _ => ""
        };

        AllFunction al = new();
        string token = al.GetToken(
            _serviceSettings.Value.ErasBaseUrl,
            _serviceSettings.Value.eirsusername,
            _serviceSettings.Value.eirspassword
        );

        string response = await al.CallAPi(url, token, "get", "");
        CorporateResponse? rootObjectVm = js.Deserialize<CorporateResponse>(response);

        return rootObjectVm;
    }
    private async Task<MainResponseAsset> StartApiHitsAssets(int pageNumber, int pageSize, int apiId)
    {
        JavaScriptSerializer js = new();
        string url = apiId switch
        {
            1 => $"{_serviceSettings.Value.ErasBaseUrl}SupplierData/PAYE_Collection_Multiple_Employees_BS_A_F_Asset?pageNumber={pageNumber}&pageSize={pageSize}",
            2 => $"{_serviceSettings.Value.ErasBaseUrl}SupplierData/PAYE_Collection_Multiple_Employees_BS_G_Asset?pageNumber={pageNumber}&pageSize={pageSize}",
            3 => $"{_serviceSettings.Value.ErasBaseUrl}SupplierData/PAYE_Collection_Multiple_Employees_BS_H_Z_Asset?pageNumber={pageNumber}&pageSize=10000",
            _ => ""
        };

        AllFunction al = new();
        string token = al.GetToken(
            _serviceSettings.Value.ErasBaseUrl,
            _serviceSettings.Value.eirsusername,
            _serviceSettings.Value.eirspassword
        );

        string response = await al.CallAPi(url, token, "get", "");
        MainResponseAsset? rootObjectVm = js.Deserialize<MainResponseAsset>(response);

        return rootObjectVm;
    }

    public async Task<ReturnObject> SycnAssessmentRules()
    {
        try
        {
            List<AssessmentRule1> ass = new();
            List<AsseRuleResult> assetList = new();
            int pageNumber = 1;
            int pageSize = 1000;
            int maxId = 0;
            for (int i = 1; i < 4; i++)
            {
                AssessmentRuleResponse response = await StartApiHitsAssessmentRule(pageNumber, pageSize, i);
                while (response.Result.Count == pageSize)
                {
                    assetList.AddRange(response.Result);
                    pageNumber++;
                    response = await StartApiHitsAssessmentRule(pageNumber, pageSize, i);
                }
                assetList.AddRange(response.Result);
            }

            foreach (var i in assetList)
            {
                ass.Add(new AssessmentRule1
                {
                    AssessmentRuleId = i.AssessmentRuleID,
                    AssessmentRuleCode = i.AssessmentRuleCode,
                    ProfileId = i.ProfileID,
                    AssessmentRuleName = i.AssessmentRuleName,
                    RuleRunId = i.RuleRunID,
                    PaymentFrequencyId = i.PaymentFrequencyID,
                    AssessmentAmount = i.AssessmentAmount,
                    TaxYear = i.TaxYear,
                    TaxMonth = i.TaxMonth,
                    PaymentOptionId = i.PaymentOptionID,
                    Active=i.Active
                });
            }
            await _dbContext.Database.ExecuteSqlRawAsync($"TRUNCATE TABLE AssessmentRules");
            _dbContext.AssessmentRules1.AddRange(ass);
            await _dbContext.SaveChangesAsync();
            return new ReturnObject { status = true, message = "Records Synced Successfully" };
        }
        catch (System.Exception ex)
        {
            return new ReturnObject
            {
                status = false,
                message = ex.Message
            };
        }
    }
    
    public async Task<ReturnObject> SycnAssessmentItems()
    {
        try
        {
            List<AssessmentItemApi> ass = new();
            List<AsseResult> assetList = new();
            int pageNumber = 1;
            int pageSize = 1000;
            int maxId = 0;
            for (int i = 1; i < 4; i++)
            {
                AssessmentResponse response = await StartApiHitsAssessmentItem(pageNumber, pageSize, i);
                while (response.Result.Count == pageSize)
                {
                    assetList.AddRange(response.Result);
                    pageNumber++;
                    response = await StartApiHitsAssessmentItem(pageNumber, pageSize, i);
                }
                assetList.AddRange(response.Result);
            }

            int myId = 0;
            foreach (var i in assetList)
            {
                myId++;
                ass.Add(new AssessmentItemApi
                {
                    Id = myId.ToString(),
                    TaxPayerId = Convert.ToInt32(i.TaxPayerID),
                    TaxPayerTypeId = Convert.ToInt32(i.TaxPayerTypeID),
                    AgencyId = Convert.ToInt32(i.AgencyID),
                    TaxPayerRin = i.TaxPayerRIN,
                    TaxPayerTypeName = i.TaxPayerTypeName,
                    AssetId = Convert.ToInt32(i.AssetID),
                    AssetTypeId = Convert.ToInt32(i.AssetTypeID),
                    AssetTypeName = i.AssetTypeName,
                    AssetRin = i.AssetRIN,
                    ProfileDescription = i.ProfileDescription,
                    ProfileId = Convert.ToInt32(i.ProfileID),
                    ProfileReferenceNo = i.ProfileReferenceNo,
                    AssessmentGroupId = Convert.ToInt32(i.AssessmentGroupID),
                    AssessmentRuleId = i.AssessmentRuleID,
                    AssessmentRuleCode = i.AssessmentRuleCode,
                    AssessmentGroupName = i.AssessmentGroupName,
                    AssessmentItemCategoryId = Convert.ToInt32(i.AssessmentItemCategoryID),
                    AssessmentItemCategoryName = i.AssessmentItemCategoryName,
                    AssessmentRuleName = i.AssessmentRuleName,
                    AssessmentItemReferenceNo = i.AssessmentItemReferenceNo,
                    AssessmentSubGroupId = Convert.ToInt32(i.AssessmentSubGroupID),
                    AssessmentSubGroupName = i.AssessmentSubGroupName,
                    RevenueStreamId = Convert.ToInt32(i.RevenueStreamID),
                    RevenueStreamName = i.RevenueStreamName,
                    RevenueSubStreamId = Convert.ToInt32(i.RevenueSubStreamID),
                    RevenueSubStreamName = i.RevenueSubStreamName,
                    AssessmentItemSubCategoryId = Convert.ToInt32(i.AssessmentItemSubCategoryID),
                    AssessmentItemName = i.AssessmentItemName,
                    AssessmentItemSubCategoryName = i.AssessmentItemSubCategoryName,
                    AgencyName = i.AgencyName,
                    ComputationId = Convert.ToInt32(i.ComputationID),
                    ComputationName = i.ComputationName,
                    TaxAmount = i.TaxAmount,
                    TaxBaseAmount = i.TaxBaseAmount,
                    Percentage = i.Percentage,
                    AssessmentItemId = Convert.ToInt32(i.AssessmentItemID)

                });
            }
            await _dbContext.Database.ExecuteSqlRawAsync($"TRUNCATE TABLE Assessment_Item_API");
            _dbContext.AssessmentItemApis.AddRange(ass);
            await _dbContext.SaveChangesAsync();
            return new ReturnObject { status = true, message = "Records Synced Successfully" };
        }
        catch (System.Exception ex)
        {
            return new ReturnObject
            {
                status = false,
                message = ex.Message
            };
        }
    }

    public async Task<ReturnObject> AllUsers(int pageNumber, int pageSize, string? searchTerm, string? username)
    {
        try
        {
            int skip = (pageNumber - 1) * pageSize;
            IQueryable<UserResponse> usersQuery;
            List<UserResponse> usersList;
            int totalRecords;

            // Determine filter based on search term
            if (string.Equals(searchTerm, "admin", StringComparison.OrdinalIgnoreCase))
            {
                usersQuery = _dbContext.AdminUsers
                    .Where(o => o.RoleId == 1)
                    .Select(item => new UserResponse
                    {
                        UserId = item.AdminUserId.ToString(),
                        UserName = item.Username,
                        UserTypeId = "1",
                        UserTypeName = "Admin",
                        Status = item.IsActive == 1 ? "Active" : "InActive"
                    });

                totalRecords = await usersQuery.CountAsync();
            }
            else if (string.Equals(searchTerm, "super admin", StringComparison.OrdinalIgnoreCase))
            {
                usersQuery = _dbContext.AdminUsers
                    .Where(o => o.RoleId == 2)
                    .Select(item => new UserResponse
                    {
                        UserId = item.AdminUserId.ToString(),
                        UserName = item.Username,
                        UserTypeId = "1",
                        UserTypeName = "Super Admin",
                        Status = item.IsActive == 1 ? "Active" : "InActive"
                    });

                totalRecords = await usersQuery.CountAsync();
            }
            else if (string.Equals(searchTerm, "company", StringComparison.OrdinalIgnoreCase))
            {
                usersQuery = _dbContext.UserManagements
                    .Select(item => new UserResponse
                    {
                        UserId = item.Id.ToString(),
                        UserName = item.CompanyName,
                        UserTypeId = "2",
                        UserTypeName = "Company",
                        Status = !item.IsDeleted ? "Active" : "InActive"
                    });

                totalRecords = await usersQuery.CountAsync();
            }
            else if (string.IsNullOrEmpty(searchTerm))
            {
                var adminUsersQuery = _dbContext.AdminUsers
                    .Where(o => o.RoleId == 1 || o.RoleId == 2)
                    .Select(item => new UserResponse
                    {
                        UserId = item.AdminUserId.ToString(),
                        UserName = item.Username,
                        UserTypeId = "1",
                        UserTypeName = item.RoleId == 1 ? "Admin" : "Super Admin",
                        Status = item.IsActive == 1 ? "Active" : "InActive"
                    });

                var companyUsersQuery = _dbContext.UserManagements
                    .Select(item => new UserResponse
                    {
                        UserId = item.Id.ToString(),
                        UserName = item.CompanyName,
                        UserTypeId = "2",
                        UserTypeName = "Company",
                        Status = !item.IsDeleted ? "Active" : "InActive"
                    });

                // Combine both queries
                usersQuery = adminUsersQuery.Concat(companyUsersQuery);
                totalRecords = await usersQuery.CountAsync();
            }
            else
            {
                return new ReturnObject
                {
                    status = false,
                    message = "Invalid Search term",
                    data = null
                };
            }
            if (!string.IsNullOrEmpty(username))
            {
                usersList = usersQuery.Where(o => o.UserName.ToLower().Trim()== username.ToLower().Trim()).ToList();
                usersList = usersList.OrderBy(u => u.UserId)
                    .Skip(skip)
                    .Take(pageSize)
                    .ToList();
            }
            else
            {
                usersList = usersQuery
                    .OrderBy(u => u.UserId)
                    .Skip(skip)
                    .Take(pageSize)
                    .ToList();
            }
           
            return new ReturnObject
            {
                status = true,
                message = "Records Pulled Successfully",
                data = new
                {
                    result = usersList,
                    totalCount = totalRecords,
                    totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize),
                    currentPage = pageNumber
                }
            };
        }
        catch (Exception ex)
        {
            // Return failure object
            return new ReturnObject
            {
                status = false,
                message = ex.Message
            };
        }
    }
    public async Task<ReturnObject> UpdateAdmin(int userTypeId, int userId, bool status, int roleId)
    {
        try
        {
            if (userTypeId == 1)
            {
                if (roleId == 0)
                    await _dbContext.AdminUsers
                    .Where(o => o.AdminUserId == userId)
                    .ExecuteUpdateAsync(user => user.SetProperty(u => u.IsActive, status ? 1 : 0));
                else
                    await _dbContext.AdminUsers
                    .Where(o => o.AdminUserId == userId)
                    .ExecuteUpdateAsync(user => user.SetProperty(u => u.RoleId, roleId));

            }
            else if (userTypeId == 2)
            {
                await _dbContext.UserManagements
                    .Where(o => o.Id == userId)
                    .ExecuteUpdateAsync(companyUser => companyUser.SetProperty(u => u.IsDeleted, status));
            }
            else
            {
                return new ReturnObject
                {
                    status = false,
                    message = "Invalid UserTypeId provided."
                };
            }

            return new ReturnObject
            {
                status = true,
                message = "User Status Updated Successfully"
            };
        }
        catch (Exception ex)
        {
            // Return failure object
            return new ReturnObject
            {
                status = false,
                message = ex.Message
            };
        }
    }


    public async Task<ReturnObject> SycnCooperate()
    {
        try
        {
            List<CompanyListApi> atpApi = new();
            List<ResultCorporate> assetList = new();
            int pageNumber = 1;
            int pageSize = 1000;
            int maxId = 0;
            for (int i = 1; i < 4; i++)
            {
                CorporateResponse response = await StartApiHitsCooperate(pageNumber, pageSize, i);
                while (response.Result.Count == pageSize)
                {
                    assetList.AddRange(response.Result);
                    pageNumber++;
                    response = await StartApiHitsCooperate(pageNumber, pageSize, i);
                }
                assetList.AddRange(response.Result);
                //i++;
            }
            foreach (var i in assetList)
            {
                atpApi.Add(new CompanyListApi
                {
                    ContactAddress = i.ContactAddress,
                    TaxPayerId = i.TaxPayerID,
                    TaxPayerTypeId = i.TaxPayerTypeID,
                    TaxPayerName = i.TaxPayerName,
                    TaxPayerRin = i.TaxPayerRIN,
                    MobileNumber = i.MobileNumber,
                    CompanyListId = 0,
                    EmailAddress = i.EmailAddress,
                    Tin = i.TIN,
                    TaxOffice = i.TaxOffice,
                    DateCreated = DateTime.UtcNow
                });

            }
            return await SyncDataAsync(atpApi, "CompanyList_API");
        }
        catch (System.Exception ex)
        {
            return new ReturnObject
            {
                status = false,
                message = ex.Message
            };
        }
    }

    public async Task<ReturnObject> SyncDataAsync<T>(List<T> entities, string tableName) where T : class
    {
        try
        {
            await _dbContext.Database.ExecuteSqlRawAsync($"TRUNCATE TABLE {tableName}");

            if (entities.Count > 0)
            {
                await BulkInsertInChunksAsync(entities);  // Call the generic bulk insert helper method
            }

            return new ReturnObject { status = true, message = "Records Synced Successfully" };
        }
        catch (System.Exception ex)
        {
            return new ReturnObject
            {
                status = false,
                message = ex.Message
            };
        }
    }

    public async Task BulkInsertInChunksAsync<T>(List<T> entities, int batchSize = 1000) where T : class
    {
        for (int i = 0; i < entities.Count; i += batchSize)
        {
            var chunk = entities.Skip(i).Take(batchSize).ToList();
            _dbContext.Set<T>().AddRange(chunk);
            await _dbContext.SaveChangesAsync();
            _dbContext.ChangeTracker.Clear();  // Clear the tracker to avoid memory overload
        }
    }
    public async Task<ReturnObject> SyncAssetAsync()
    {
        List<BusinessesApiMain> bsApi = new();
        List<AssetTaxPayerDetailsApi> atpApi = new();
        List<AssestResult> assetList = new();
        int pageNumber = 1;
        int pageSize = 1000;
        for (int i = 1; i < 4; i++)
        {
            MainResponseAsset response = await StartApiHitsAssets(pageNumber, pageSize, i);
            while (response.Result.Count == pageSize)
            {
                assetList.AddRange(response.Result);
                pageNumber++;
                response = await StartApiHitsAssets(pageNumber, pageSize, i);
            }
            assetList.AddRange(response.Result);
        }

        foreach (var ret in assetList)
        {

            var cosMap = new AssetTaxPayerDetailsApi
            {
                //Id = maxId,
                Tpaid = 0,
                TaxPayerRoleId = 0,
                TaxPayerRoleName = "",
                BuildingUnitId = "",
                UnitNumber = "",
                Active = "",
                ActiveText = "",
                DateCreated = DateTime.Now,
                TaxPayerTypeId = ret.TaxPayerTypeID,
                TaxPayerTypeName = ret.TaxPayerTypeName,
                TaxPayerName = ret.TaxPayerName,
                TaxPayerId = ret.TaxPayerID,
                AssetAddress = ret.BusinessAddress,
                TaxPayerRinnumber = ret.TaxPayerRIN,
                TaxPayerEmailAddress = "",
                TaxPayerMobileNumber = ret.BusinessNumber,
                AssetTypeId = ret.AssetTypeID,
                AssetTypeName = ret.AssetTypeName,
                AssetId = ret.BusinessID,
                AssetLga = ret.LGAName,
                AssetName = ret.BusinessName,
                AssetRin = ret.BusinessRIN
            };
            atpApi.Add(cosMap);
            var cos = new BusinessesApiMain()
            {
                BusinessId = ret.BusinessID,
                BusinessRin = ret.BusinessRIN,
                AssetTypeId = ret.AssetTypeID,
                AssetTypeName = ret.AssetTypeName,
                BusinessTypeId = ret.BusinessTypeID,
                BusinessTypeName = ret.BusinessTypeName,
                BusinessName = ret.BusinessName,
                Lgaid = ret.LGAID,
                Lganame = ret.LGAName,
                DateCreated = DateTime.Now,
                BusinessCategoryId = ret.BusinessCategoryID,
                BusinessCategoryName = ret.BusinessCategoryName,
                BusinessSectorId = ret.BusinessSectorID,
                BusinessSectorName = ret.BusinessSectorName,
                BusinessSubSectorId = ret.BusinessSubSectorID,
                BusinessSubSectorName = ret.BusinessSubSectorName,
                BusinessOperationId = ret.BusinessOperationID,
                BusinessOperationName = ret.BusinessOperationName,
                SizeId = ret.SizeID,
                BusinessStructureId = ret.BusinessStructureID,
                BusinessStructureName = ret.BusinessStructureName,
                SizeName = ret.SizeName,
                ContactName = ret.ContactName,
                BusinessNumber = ret.BusinessNumber,
                BusinessAddress = ret.BusinessAddress
            };
            bsApi.Add(cos);
        }
        // Call the generic SyncDataAsync for each entity type
        var assetSyncResult = await SyncDataAsync(atpApi, "AssetTaxPayerDetails_API");
        var businessSyncResult = await SyncDataAsync(bsApi, "Businesses_API_Main");

        if (!assetSyncResult.status || !businessSyncResult.status)
        {
            return new ReturnObject
            {
                status = false,
                message = "Asset or Business data sync failed."
            };
        }

        return new ReturnObject { status = true, message = "Assets and Businesses Synced Successfully" };
    }

    public async Task<List<EmployeesMonthlySchedule>> GetAssessmentSchudeleDetailsDownLoad(EmpMtAssForPdf ass)
    {
        var getId = await _dbContext.AssetTaxPayerDetailsApis.
                    FirstOrDefaultAsync(x => x.AssetRin == ass.BusinessRin && x.TaxPayerRinnumber == ass.CompanyRin);

        var buss = await _dbContext.EmployeesMonthlySchedules.Where(
            e => e.BusinessId == getId.AssetId.ToString() &&
                        e.EmployerId == getId.TaxPayerId.ToString()
                       /* && e.AssessementStatusId == 1*/)
            .Select(e => new EmployeesMonthlySchedule
            {
                EmployeeRin = e.EmployeeRin,
                BusinessId = e.BusinessId,
                EmployerId = e.EmployerId,
                TaxMonth = e.TaxMonth,
                TaxYear = e.TaxYear
            })
            .ToListAsync();

        return buss;
    }
    private int GetMonthIdByName(string monthName)
    {
        // Convert the month name to title case to handle case sensitivity
        monthName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthName.ToLower());

        // Parse the month name to get the corresponding month ID
        DateTime result;
        if (DateTime.TryParseExact(monthName, "MMMM", System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None, out result))
        {
            return result.Month;
        }

        // If the month name is invalid, return -1 or throw an exception
        return -1;  // Or throw new ArgumentException("Invalid month name");
    }

    public async Task<ReturnObject> Login(AdminSignUp adminSign)
    {
        var r = new ReturnObject();
        try
        {
            var userExist = _repo.AdminUsers.FirstOrDefault(o => o.Email == adminSign.UserName);

            string url = _serviceSettings.Value.ErasBaseUrl;
            url = url + $"User/TaxOfficer?EmailAddress={adminSign.UserName}";
            AllFunction al = new AllFunction();
            var response = await al.CallAPi(url, "", "Get", "");
            var apiRecords = JsonConvert.DeserializeObject<TaxOfficerLoginDetail>(response);
            if (apiRecords.Result == null)
            {
                return new ReturnObject
                {
                    status = false,
                    message = "User Not Found From Eras"
                };
            }

            if (userExist == null)
            {
                var user = new Models.AdminUser
                {
                    TaxOfficeId = apiRecords.Result.TaxOfficeID,
                    TaxOfficeName = apiRecords.Result.TaxOfficeName,
                    Username = apiRecords.Result.UserName,
                    Email = apiRecords.Result.EmailAddress,
                    Phone = apiRecords.Result.ContactNumber,
                    ContactName = apiRecords.Result.ContactName
                };
                _dbContext.AdminUsers.Add(user);
            }
            else
            {
                userExist.TaxOfficeId = apiRecords.Result.TaxOfficeID;
                userExist.TaxOfficeName = apiRecords.Result.TaxOfficeName;
                userExist.Username = apiRecords.Result.UserName;
                userExist.Email = apiRecords.Result.EmailAddress;
                //userExist.Phone = apiRecords.Result.ContactNumber;
                userExist.ContactName = apiRecords.Result.ContactName;
            };

            _dbContext.SaveChanges();
        }
        catch (System.Exception ex)
        {
            return new ReturnObject
            {
                status = false,
                message = ex.Message
            };
        }
        return r;
    }

    public async Task<Dictionary<IQueryable<Models.AssetTaxPayerDetailsApi>, int>> GetCompanyTiedToAdminUser(string tx_cm, bool det, int pgNo, int pgSize)
    {
        IQueryable<Models.AssetTaxPayerDetailsApi> busDetail;
        int totalCount = 0;
        if (det)
        {
            var comap = _dbContext.CompanyListApis
          .Where(o => o.TaxOffice.ToLower().Trim() == tx_cm.ToLower().Trim())
          .Select(o => o.TaxPayerRin.ToLower());

            // total count
            totalCount = await comap.CountAsync();

            //  comap = comap.Skip((pgNo - 1) * pgSize)
            //.Take(pgSize);
            busDetail = _dbContext.AssetTaxPayerDetailsApis
                .Where(o => comap.Contains(o.TaxPayerRinnumber.ToLower().Trim()));
        }
        else
        {
            if (tx_cm.StartsWith("CMP") || tx_cm.StartsWith("GOV"))
            {
                busDetail = _dbContext.AssetTaxPayerDetailsApis
                    .Where(o => o.TaxPayerRinnumber == tx_cm);
            }
            else
            {
                busDetail = _dbContext.AssetTaxPayerDetailsApis
                    .Where(o => o.TaxPayerId.ToString() == tx_cm);
            }
            totalCount = await busDetail.CountAsync();
        }
        return new Dictionary<IQueryable<Models.AssetTaxPayerDetailsApi>, int>
        { { busDetail, totalCount } };
    }

}
