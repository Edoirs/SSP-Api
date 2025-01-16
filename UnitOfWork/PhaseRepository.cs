//using SelfPortalAPi.Model;
namespace SelfPortalAPi.UnitOfWork;
public interface IPhaseIIRepo
{
    Task<Dictionary<List<AssetTaxPayerDetailsApiResponse>, int>> GetCompanyTiedToSuperAdminUser(Formh1SuperAdmin formh1, List<long>? ids);
    Task<Dictionary<string, object>> GetAllBusinessesAsync(int pageNumber, int pageSize, string busName, string tx_cm, bool IsAdmin);
    Task<Dictionary<string, object>> GetAllBusinessesAsync(int pageNumber, int pageSize, string busName, Formh1SuperAdmin formh1);
    Task<ReturnObject> SyncAssetAsync();
    Task<ReturnObject> AllUsers(int pageNumber, int pageSize, string? searchTerm, string? username);
    Task<ReturnObject> UpdateAdmin(int userTypeId, int userId, bool status, int roleId);
    Task<ReturnObject> SycnCooperate();
    Task<ReturnObject> SycnAssessmentItems();
    Task<ReturnObject> SycnAssessmentRules();
    Task<Dictionary<List<ReturnEmployeeMon>, int>> getallEmployeesCount(int pageNumber, int pageSize, string busName, string tx_cm, bool IsAdmin, bool IsAssessmentOfficer, Formh1SuperAdmin formh1);
    Task<List<EmployeeIncomeVm>> GetEmployeeIncomeView(EmployeesViewFmModel emp);
    Task<List<EmployeesMonthlyIncome>> GetMonthlyIncomeAsync(EmpSchedule obj);
    Task<List<EmployeesMonthlyIncome>> GetEmployeeMonthlyIncomeAsync(EmpSchedule obj);
    Task<List<EmpScheduleDetails>> CalculateMonthScheduleAsync(EmpSchedule empSch);
    Task<ReturnObject> Login(AdminSignUp adminSign);
    Task<Dictionary<List<AssetTaxPayerDetailsApiResponse>, int>> GetCompanyTiedToAdminUser(string tx_cm, bool det, int pgNo, int pgSize);
    int CalculateMonthsLeft(string monthName);
    decimal CalculateTax(decimal ch_income, decimal gross);
    Task<List<ScheduleGetViewRes>> GetSchedulesViewAsync(EmpSchFm empSch);
    Task<List<AssessmentRDMRes>> GetAssessmentRDMAsync(BusSchFm1 obj);
    Task<List<Models.AssetTaxPayerDetailsApi>> GetBusinessDetails(string BusinessRin, string CompanyRin);
    Task<List<EmployeesMonthlySchedule>> GetAssessmentSchudeleDetails(EmpMtAss ass);
    Task<List<EmployeesMonthlySchedule>> GetAssessmentScheduleDetails2(EmpMtAssNew ass);
    Task<List<EmployeesMonthlySchedule>> GetAssessmentSchudeleDetailsDownLoad(EmpMtAssForPdf ass);
    Task<ReturnObject> ReAssessFormH1(FormH1FormModelForReassess ass);
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
    public async Task<Dictionary<string, object>> GetAllBusinessesAsync(int pageNumber, int pageSize, string busName, Formh1SuperAdmin formh1)
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
        totalCount = await bigQuery.CountAsync();
        if (string.IsNullOrEmpty(formh1.busRin) &&
         string.IsNullOrEmpty(formh1.companyRin) &&
         string.IsNullOrEmpty(formh1.companyName) &&
         string.IsNullOrEmpty(formh1.businessName) &&
         string.IsNullOrEmpty(busName))
        {
            pageRes = await bigQuery
              .Skip((formh1.pageNumber - 1) * formh1.pageSize)
              .Take(formh1.pageSize)
              .ToListAsync();
        }
        else
        {
            if (!string.IsNullOrEmpty(busName))
            {
                bigQuery = bigQuery.Where(o =>
    o.BusinessName.ToLower().Trim().Contains(busName.ToLower().Trim()) ||
    o.CompanyRin.ToLower().Trim().Contains(busName.ToLower().Trim()) ||
    o.CompanyName.ToLower().Trim().Contains(busName.ToLower().Trim())
    );
                pageRes = await bigQuery
              .Skip((formh1.pageNumber - 1) * formh1.pageSize)
              .Take(formh1.pageSize)
              .ToListAsync();
            }
            else
            {
                bigQuery = bigQuery.Where(o =>
    o.BusinessName.ToLower().Trim().Contains(formh1.businessName) ||
    o.CompanyRin.ToLower().Trim().Contains(formh1.companyRin) ||
    o.CompanyName.ToLower().Trim().Contains(formh1.companyName)
    );
                pageRes = await bigQuery
              .Skip((formh1.pageNumber - 1) * formh1.pageSize)
              .Take(formh1.pageSize)
              .ToListAsync();
            }

        }
        return new Dictionary<string, object>
{
    { "Businesses", pageRes },
    { "TotalCount", totalCount }
};
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
                    query = bigQuery.Where(o =>
    o.TaxOffice.ToLower().Trim() == tx_cm.ToLower().Trim() &&
    (
        o.BusinessName.ToLower().Trim().Contains(busName.ToLower().Trim()) ||
        o.CompanyRin.ToLower().Trim().Contains(busName.ToLower().Trim()) ||
        o.CompanyName.ToLower().Trim().Contains(busName.ToLower().Trim())
    )
);
                    break;
                case false:
                    query = bigQuery.Where(
                        o =>
    o.CompanyRin.ToLower().Trim() == tx_cm.ToLower().Trim() &&
    (
        o.BusinessName.ToLower().Trim().Contains(busName.ToLower().Trim()) ||
        o.CompanyRin.ToLower().Trim().Contains(busName.ToLower().Trim()) ||
        o.CompanyName.ToLower().Trim().Contains(busName.ToLower().Trim())
    )); break;
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

            //pageRes = pageRes.DistinctBy(o => o.BusinessName).ToList();
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
    public async Task<Dictionary<List<ReturnEmployeeMon>, int>> getallEmployeesCount(int pageNumber, int pageSize, string busName, string tx_cm, bool IsAdmin, bool IsAssessmentOfficer, Formh1SuperAdmin formh1)
    {
        IDictionary<List<AssetTaxPayerDetailsApiResponse>, int> busDetail;
        if (string.IsNullOrEmpty(busName))
            busName = formh1.companyName;
        if (string.IsNullOrEmpty(busName))
            busName = formh1.companyRin;
        if (string.IsNullOrEmpty(busName))
            busName = formh1.businessName;
        if (string.IsNullOrEmpty(busName))
            busName = formh1.busRin;

        string query = "";
        int totalCount = 0;
        IQueryable<string>? list;
        if (string.IsNullOrEmpty(busName))
        {
            if (IsAssessmentOfficer)
            {
                query =
                @$"
         select a.taxpayerid companyID, a.taxpayername companyName, a.assetid businessId, a.taxpayerrinnumber companyRIN, a.assetname businessName, a.assetrin businessRIN, a.AssetLGA businesslga, a.AssetAddress businessAddress, count(e.employeeid) noOfEmployees, c.taxoffice taxOffice
from AssetTaxPayerDetails_API a 
left join EmployeesMonthlyIncome e on a.TaxPayerID = e.CompanyId and a.AssetID = e.BusinessId 
left join CompanyList_API c on a.TaxPayerRINNumber = c.TaxPayerRIN
group by a.taxpayerid, a.TaxPayerName, a.assetid, a.TaxPayerRINNumber, a.AssetName, a.AssetRIN, a.AssetLGA, a.AssetAddress, c.TaxOffice";


            }
            else
            {
                if (IsAdmin)
                {
                    busDetail = await GetCompanyTiedToAdminUser(tx_cm, true, pageNumber, pageSize);
                    string taxPayerRinString = string.Join(", ", busDetail
        .SelectMany(b => b.Key)
        .Select(k => $"\'{k.TaxPayerRinnumber}\'")
        .Where(rin => !string.IsNullOrEmpty(rin)));
                    query = @$"
             select a.taxpayerid companyID, a.taxpayername companyName, a.assetid businessId, a.taxpayerrinnumber companyRIN, a.assetname businessName, a.assetrin businessRIN, a.AssetLGA businesslga, a.AssetAddress businessAddress, count(e.employeeid) noOfEmployees, c.taxoffice taxOffice
from AssetTaxPayerDetails_API a 
left join EmployeesMonthlyIncome e on a.TaxPayerID = e.CompanyId and a.AssetID = e.BusinessId 
left join CompanyList_API c on a.TaxPayerRINNumber = c.TaxPayerRIN
            WHERE 
                a.TaxPayerRINNumber IN ({taxPayerRinString})
            group by a.taxpayerid, a.TaxPayerName, a.assetid, a.TaxPayerRINNumber, a.AssetName, a.AssetRIN, a.AssetLGA, a.AssetAddress, c.TaxOffice";

                }
                else
                {
                    // For non-admin users
                    string cm = "";
                    busDetail = await GetCompanyTiedToAdminUser(tx_cm, false, pageNumber, pageSize);
                    cm = busDetail.FirstOrDefault().Key.FirstOrDefault().TaxPayerRinnumber;
                    query = @$"
                     select a.taxpayerid companyID, a.taxpayername companyName, a.assetid businessId, a.taxpayerrinnumber companyRIN, a.assetname businessName, a.assetrin businessRIN, a.AssetLGA businesslga, a.AssetAddress businessAddress, count(e.employeeid) noOfEmployees, c.taxoffice taxOffice
from AssetTaxPayerDetails_API a 
left join EmployeesMonthlyIncome e on a.TaxPayerID = e.CompanyId and a.AssetID = e.BusinessId 
left join CompanyList_API c on a.TaxPayerRINNumber = c.TaxPayerRIN
WHERE 
                a.TaxPayerRINNumber = '{cm}'
            
               group by a.taxpayerid, a.TaxPayerName, a.assetid, a.TaxPayerRINNumber, a.AssetName, a.AssetRIN, a.AssetLGA, a.AssetAddress, c.TaxOffice";

                }
            }
        }
        else
        {

            busDetail = await GetCompanyTiedToAdminUser(tx_cm, false, pageNumber, pageSize);
            query = @$"
                 select a.taxpayerid companyID, a.taxpayername companyName, a.assetid businessId, a.taxpayerrinnumber companyRIN, a.assetname businessName, a.assetrin businessRIN, a.AssetLGA businesslga, a.AssetAddress businessAddress, count(e.employeeid) noOfEmployees, c.taxoffice taxOffice
from AssetTaxPayerDetails_API a 
left join EmployeesMonthlyIncome e on a.TaxPayerID = e.CompanyId and a.AssetID = e.BusinessId 
left join CompanyList_API c on a.TaxPayerRINNumber = c.TaxPayerRIN
WHERE 
    a.TaxPayerName LIKE '%{busName}%'
    OR a.AssetName LIKE '%{busName}%'
    OR a.TaxPayerRINNumber LIKE '%{busName}%'
    OR a.AssetRIN LIKE '%{busName}%'
group by a.taxpayerid, a.TaxPayerName, a.assetid, a.TaxPayerRINNumber, a.AssetName, a.AssetRIN, a.AssetLGA, a.AssetAddress, c.TaxOffice";

        }

        var pageRes = await _dbContext.Set<ReturnEmployeeMon>()
            .FromSqlRaw(query)
            .ToListAsync();

        totalCount = pageRes.Count();

        // If no results found, return a default empty result
        if (!pageRes.Any())
        {
            // var bDetail = busDetail.FirstOrDefault().Key.FirstOrDefault();
            ReturnEmployeeMon bvnm = new ReturnEmployeeMon
            {
            };
            pageRes.Add(bvnm);
            totalCount = 1;
        }
        if (pageNumber != 0 && pageSize != 0)
        {
            pageRes = pageRes
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
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

            var assessmentItemsQuery = from ai in _dbContext.AssessmentItems
                                       where ai.AssessmentItemName.Contains(obj.TaxMonth)
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
    private async Task<RootobjectItem> StartApiHitsAssessmentItem(int pageNumber, int pageSize, int apiId)
    {
        JavaScriptSerializer js = new();
        string url = apiId switch
        {
            1 => $"{_serviceSettings.Value.ErasBaseUrl}User/GetAssessentItems?pageNumber={pageNumber}&pageSize={pageSize}&RevId=8",
            2 => $"{_serviceSettings.Value.ErasBaseUrl}User/GetAssessentItems?pageNumber={pageNumber}&pageSize={pageSize}&RevId=8",
            3 => $"{_serviceSettings.Value.ErasBaseUrl}User/GetAssessentItems?pageNumber={pageNumber}&pageSize=10000&RevId=8",
            _ => ""
        };

        AllFunction al = new();
        string token = al.GetToken(
            _serviceSettings.Value.ErasBaseUrl,
            _serviceSettings.Value.eirsusername,
            _serviceSettings.Value.eirspassword
        );

        string response = await al.CallAPi(url, token, "get", "");
        RootobjectItem? rootObjectVm = js.Deserialize<RootobjectItem>(response);

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
            int ii = 1;

            AssessmentRuleResponse response = await StartApiHitsAssessmentRule(pageNumber, pageSize, ii);
            while (response.Result.Data.Count() == pageSize)
            {
                assetList.AddRange(response.Result.Data);
                pageNumber++;
                response = await StartApiHitsAssessmentRule(pageNumber, pageSize, ii++);
            }
            assetList.AddRange(response.Result.Data);

            int myId = 0;
            foreach (var i in assetList)
            {
                myId++;
                ass.Add(new AssessmentRule1
                {
                    Id = myId,
                    AssessmentRuleId = i.AssessmentRuleID,
                    AssessmentRuleCode = i.AssessmentRuleCode,
                    ProfileId = i.ProfileID,
                    AssessmentRuleName = i.AssessmentRuleName,
                    RuleRunId = i.RuleRunID,
                    PaymentFrequencyId = i.PaymentFrequencyID,
                    AssessmentAmount = i.AssessmentAmount,
                    TaxYear = i.TaxYear,
                    TaxMonth = GetMonthNumberFromSentence(i.AssessmentRuleName),
                    PaymentOptionId = i.PaymentOptionID,
                    Active = i.Active
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
            List<AssessmentItem> ass = new();
            List<Datum> assetList = new();
            int pageNumber = 1;
            int pageSize = 1000;
            int ii = 1;
            // for (int i = 1; i < 4; i++)
            //{
            RootobjectItem response = await StartApiHitsAssessmentItem(pageNumber, pageSize, ii);
            while (response.Result.Data.Count() == pageSize)
            {
                assetList.AddRange(response.Result.Data);
                pageNumber++;
                response = await StartApiHitsAssessmentItem(pageNumber, pageSize, ii++);
            }
            assetList.AddRange(response.Result.Data);

            //int myId = 0;
            foreach (var i in assetList)
            {
                // myId++;
                ass.Add(new AssessmentItem
                {
                    // Id = myId.ToString(),
                    AssessmentItemId = i.AssessmentItemID,
                    AssessmentItemReferenceNo = i.AssessmentItemReferenceNo,
                    AssessmentSubGroupId = Convert.ToInt32(i.AssessmentSubGroupID),
                    AgencyId = Convert.ToInt32(i.AgencyID),
                    AssetTypeId = Convert.ToInt32(i.AssetTypeID),
                    AssessmentGroupId = Convert.ToInt32(i.AssessmentGroupID),
                    AssessmentItemCategoryId = Convert.ToInt32(i.AssessmentItemCategoryID),
                    RevenueStreamId = Convert.ToInt32(i.RevenueStreamID),
                    RevenueSubStreamId = Convert.ToInt32(i.RevenueSubStreamID),
                    AssessmentItemSubCategoryId = Convert.ToInt32(i.AssessmentItemSubCategoryID),
                    AssessmentItemName = i.AssessmentItemName,
                    ComputationId = Convert.ToInt32(i.ComputationID),
                    TaxAmount = Convert.ToDecimal(i.TaxAmount),
                    TaxBaseAmount = Convert.ToDecimal(i.TaxBaseAmount),
                    Active = i.Active,
                    Percentage = Convert.ToDecimal(i.Percentage)
                });
            }
            await _dbContext.Database.ExecuteSqlRawAsync($"TRUNCATE TABLE Assessment_Items");
            _dbContext.AssessmentItems.AddRange(ass);
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
                        UserTypeId = "2",
                        UserTypeName = "Super Admin",
                        Status = item.IsActive == 1 ? "Active" : "InActive"
                    });

                totalRecords = await usersQuery.CountAsync();
            }
            else if (string.Equals(searchTerm, "assessment officer", StringComparison.OrdinalIgnoreCase))
            {
                usersQuery = _dbContext.AdminUsers
                    .Where(o => o.RoleId == 3)
                    .Select(item => new UserResponse
                    {
                        UserId = item.AdminUserId.ToString(),
                        UserName = item.Username,
                        UserTypeId = "3",
                        UserTypeName = "Assessment Officer",
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
    .Where(o => o.RoleId == 1 || o.RoleId == 2 || o.RoleId == 3)
    .Select(item => new UserResponse
    {
        UserId = item.AdminUserId.ToString(),
        UserName = item.Username,
        UserTypeId = "1",
        UserTypeName = item.RoleId == 1
            ? "Admin"
            : item.RoleId == 2
                ? "Super Admin"
                : "Assessment Officer",
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
                usersList = usersQuery.Where(o => o.UserName.ToLower().Trim() == username.ToLower().Trim()).ToList();
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
                pageNumber = 1;
                assetList.AddRange(response.Result);
                //i++;
            }
            List<ResultCorporate> distinctCorporates = assetList
            .GroupBy(c => c.TaxPayerRIN)
            .Select(g => g.First())
            .ToList();
            foreach (var i in distinctCorporates)
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
            pageNumber = 1;
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

    public int GetMonthNumberFromSentence(string sentence)
    {
        // Define a regex pattern to match month names (case insensitive)
        string monthPattern = @"\b(january|february|march|april|may|june|july|august|september|october|november|december)\b";

        // Use Regex to find the month in the sentence (case insensitive)
        var match = Regex.Match(sentence, monthPattern, RegexOptions.IgnoreCase);

        // If a match is found, get the month name
        if (match.Success)
        {
            // Get the matched month name in lowercase
            string monthName = match.Value.ToLower();

            // Dictionary to map month names to their corresponding month numbers
            var months = new System.Collections.Generic.Dictionary<string, int>()
            {
                { "january", 1 },
                { "february", 2 },
                { "march", 3 },
                { "april", 4 },
                { "may", 5 },
                { "june", 6 },
                { "july", 7 },
                { "august", 8 },
                { "september", 9 },
                { "october", 10 },
                { "november", 11 },
                { "december", 12 }
            };

            // Return the corresponding month number from the dictionary
            return months[monthName];
        }
        else
        {
            return 0;
        }
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
                    TaxOfficeId = Convert.ToInt32(apiRecords.Result.TaxOfficeID),
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
                userExist.TaxOfficeId = Convert.ToInt32(apiRecords.Result.TaxOfficeID);
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


    //public async Task<Dictionary<List<AssetTaxPayerDetailsApi>, int>> GetCompanyTiedToSuperAdminUser(Formh1SuperAdmin formh1, List<long> ids)
    //{
    //    var busDetails = new List<AssetTaxPayerDetailsApi>();
    //    int totalCount = 0;
    //    IQueryable<CompanyListApi> companiesQuery = null;
    //    // Queryable objects for deferred execution
    //    if (!ids.Any())
    //        companiesQuery = _dbContext.CompanyListApis.AsQueryable();
    //    else
    //        companiesQuery = _dbContext.CompanyListApis.Where(o => ids.Contains(o.TaxPayerId)).AsQueryable();
    //    var assetsQuery = _dbContext.AssetTaxPayerDetailsApis.AsQueryable();

    //    if (string.IsNullOrEmpty(formh1.busRin) &&
    //        string.IsNullOrEmpty(formh1.companyRin) &&
    //        string.IsNullOrEmpty(formh1.companyName) &&
    //        string.IsNullOrEmpty(formh1.businessName))
    //    {
    //        // Get the total count of companies
    //        totalCount = await companiesQuery.CountAsync();

    //        // Paginated list of company RINs
    //        var rinList = await companiesQuery
    //            .Skip((formh1.pageNumber - 1) * formh1.pageSize)
    //            .Take(formh1.pageSize)
    //            .Select(o => o.TaxPayerRin.ToLower())
    //            .ToListAsync();

    //        // Filter assets based on company RINs
    //        busDetails = await assetsQuery
    //            .Where(o => rinList.Contains(o.TaxPayerRinnumber.ToLower().Trim()))
    //            .ToListAsync();
    //    }
    //    else
    //    {
    //        // Filter companies based on provided criteria
    //        var companyRinsQuery = companiesQuery
    //            .Where(o => o.TaxPayerName.Contains(formh1.companyName) ||
    //                        o.TaxPayerRin.Contains(formh1.companyRin))
    //            .Select(o => o.TaxPayerRin.ToLower());

    //        // Get the total count of filtered companies
    //        totalCount = await companyRinsQuery.CountAsync();

    //        if (totalCount > 0)
    //        {
    //            // Get the filtered company RINs
    //            var rinList = await companyRinsQuery.ToListAsync();

    //            // Filter assets based on filtered company RINs
    //            busDetails = await assetsQuery
    //                .Where(o => rinList.Contains(o.TaxPayerRinnumber.ToLower().Trim()))
    //                .ToListAsync();
    //        }
    //        else
    //        {
    //            // Fallback to filtering assets directly
    //            busDetails = await assetsQuery
    //                .Where(o => o.AssetName.Contains(formh1.businessName) ||
    //                            o.AssetRin.Contains(formh1.busRin))
    //                .ToListAsync();
    //        }
    //    }

    //    return new Dictionary<List<Models.AssetTaxPayerDetailsApi>, int>
    //    { { busDetails, totalCount } };
    //}
    public async Task<Dictionary<List<AssetTaxPayerDetailsApiResponse>, int>> GetCompanyTiedToSuperAdminUser(Formh1SuperAdmin formh1, List<long> ids)
    {

        var busDetails = new List<AssetTaxPayerDetailsApiResponse>();
        int totalCount = 0;
        IQueryable<CompanyListApi> companiesQuery = null;
        string query = $@"
    SELECT  [TPAID]
          ,A.[TaxPayerTypeID]
          ,A.[TaxPayerTypeName]
          ,A.[TaxPayerID]
          ,A.[TaxPayerName]
          ,c.TaxOffice
          ,[TaxPayerRINNumber]
          ,[TaxPayerEmailAddress]
          ,[TaxPayerMobileNumber]
          ,[AssetTypeID]
          ,[AssetTypeName]
          ,[TaxPayerRoleID]
          ,[TaxPayerRoleName]
          ,[AssetID]
          ,[AssetLGA]
          ,[AssetRIN]
          ,[AssetName]
          ,[BuildingUnitID]
          ,[UnitNumber]
          ,[Active]
          ,[ActiveText]
          ,A.[DateCreated]
          ,[Id]
          ,A.[ApiId]
          ,[AssetAddress]
    FROM [SELFSERVICE].[dbo].[AssetTaxPayerDetails_API] A
    LEFT JOIN CompanyList_API c ON A.TaxPayerID = c.TaxPayerID
 @@@";
        if (string.IsNullOrEmpty(formh1.busRin) &&
            string.IsNullOrEmpty(formh1.companyRin) &&
            string.IsNullOrEmpty(formh1.companyName) &&
            string.IsNullOrEmpty(formh1.businessName))
        {
            if (ids.Any())
            {
                var idsStr = string.Join(",", ids);
                query = query.Replace("@@@", $"WHERE c.TaxPayerID IN ({idsStr})");


                // Execute the raw SQL query with the provided list of IDs
                busDetails = await _repo.AssetTaxPayerDetailsApiResponse
                    .FromSqlRaw(query)
                    .ToListAsync();
            }
            else
            {
                query = query.Replace("@@@", "");
                busDetails = await _repo.AssetTaxPayerDetailsApiResponse
                    .FromSqlRaw(query)
                    .ToListAsync();

            }

        }
        else
        {

            query = query.Replace("@@@", $"WhERE c.TaxPayerName like '{formh1.companyName}' or a.AssetName like '{formh1.businessName}' or a.AssetRIN like '{formh1.busRin}' or a.TaxPayerRINNumber like '{formh1.companyRin}'");
            busDetails = await _repo.AssetTaxPayerDetailsApiResponse
                    .FromSqlRaw(query)
                    .ToListAsync();
        }
        totalCount = busDetails.Count;
        return new Dictionary<List<AssetTaxPayerDetailsApiResponse>, int>
        { { busDetails, totalCount } };
    }

    public async Task<Dictionary<List<AssetTaxPayerDetailsApiResponse>, int>> GetCompanyTiedToAdminUser(string tx_cm, bool det, int pgNo, int pgSize)
    {
        string query = @"
    SELECT  [TPAID]
          ,A.[TaxPayerTypeID]
          ,A.[TaxPayerTypeName]
          ,A.[TaxPayerID]
          ,A.[TaxPayerName]
          ,c.TaxOffice
          ,[TaxPayerRINNumber]
          ,[TaxPayerEmailAddress]
          ,[TaxPayerMobileNumber]
          ,[AssetTypeID]
          ,[AssetTypeName]
          ,[TaxPayerRoleID]
          ,[TaxPayerRoleName]
          ,[AssetID]
          ,[AssetLGA]
          ,[AssetRIN]
          ,[AssetName]
          ,[BuildingUnitID]
          ,[UnitNumber]
          ,[Active]
          ,[ActiveText]
          ,A.[DateCreated]
          ,[Id]
          ,A.[ApiId]
          ,[AssetAddress]
    FROM [SELFSERVICE].[dbo].[AssetTaxPayerDetails_API] A
    LEFT JOIN CompanyList_API c ON A.TaxPayerID = c.TaxPayerID
 @@@";
        List<AssetTaxPayerDetailsApiResponse> busDetail = new List<AssetTaxPayerDetailsApiResponse>();
        int totalCount = 0;
        if (det)
        {
            if (!string.IsNullOrEmpty(tx_cm) && tx_cm.ToLower() != "null")
            {
                query = query.Replace("@@@", $"WHERE c.Taxoffice = '{tx_cm.ToLower()}'");
            }
            else
            {
                query = query.Replace("@@@", "");
            }
            //var allQualified =await busDetail.ToListAsync();
        }
        else
        {
            if (tx_cm.StartsWith("CMP") || tx_cm.StartsWith("GOV"))
            {
                query = query.Replace("@@@", $"WHERE a.TaxPayerRINNumber = '{tx_cm.ToLower()}'");
            }
            else
            {
                query = query.Replace("@@@", $"WHERE a.TaxPayerID = {tx_cm}");
            }
            busDetail = await _repo.AssetTaxPayerDetailsApiResponse
                 .FromSqlRaw(query)
                 .ToListAsync();
            totalCount = busDetail.Count();
        }
        return new Dictionary<List<AssetTaxPayerDetailsApiResponse>, int>
        { { busDetail, totalCount } };
    }
    //public async Task<Dictionary<List<Models.AssetTaxPayerDetailsApi>, int>> GetCompanyTiedToAdminUser(string tx_cm, bool det, int pgNo, int pgSize)
    //{
    //    List<AssetTaxPayerDetailsApi> busDetail = new List<AssetTaxPayerDetailsApi>();
    //    int totalCount = 0;
    //    if (det)
    //    {
    //        if (!string.IsNullOrEmpty(tx_cm) && tx_cm.ToLower() != "null")
    //        {
    //            var comap = _dbContext.CompanyListApis
    //          .Where(o => o.TaxOffice.ToLower().Trim() == tx_cm.ToLower().Trim())
    //          .Select(o => o.TaxPayerRin.ToLower());

    //            // total count
    //            totalCount = await comap.CountAsync();

    //            //all rin
    //            var rin = await comap.ToListAsync();
    //            //  comap = comap.Skip((pgNo - 1) * pgSize)
    //            //.Take(pgSize);
    //            busDetail = _dbContext.AssetTaxPayerDetailsApis
    //                .Where(o => rin.Contains(o.TaxPayerRinnumber.ToLower().Trim())).ToList();
    //        }
    //        else
    //        {
    //            var comap = _dbContext.CompanyListApis
    //          //.Where(o => o.TaxOffice.ToLower().Trim() == tx_cm.ToLower().Trim())
    //          .Select(o => o.TaxPayerRin.ToLower());

    //            // total count
    //            totalCount = await comap.CountAsync();

    //            //all rin
    //            var rin = await comap.ToListAsync();
    //            //  comap = comap.Skip((pgNo - 1) * pgSize)
    //            //.Take(pgSize);
    //            busDetail = _dbContext.AssetTaxPayerDetailsApis
    //                .Where(o => rin.Contains(o.TaxPayerRinnumber.ToLower().Trim())).ToList();
    //        }
    //        //var allQualified =await busDetail.ToListAsync();
    //    }
    //    else
    //    {
    //        if (tx_cm.StartsWith("CMP") || tx_cm.StartsWith("GOV"))
    //        {
    //            busDetail = _dbContext.AssetTaxPayerDetailsApis
    //                .Where(o => o.TaxPayerRinnumber == tx_cm).ToList();
    //        }
    //        else
    //        {
    //            busDetail = _dbContext.AssetTaxPayerDetailsApis
    //                .Where(o => o.TaxPayerId.ToString() == tx_cm).ToList();
    //        }
    //        totalCount = busDetail.Count();
    //    }
    //    return new Dictionary<List<Models.AssetTaxPayerDetailsApi>, int>
    //    { { busDetail, totalCount } };
    //}

    public async Task<ReturnObject> ReAssessFormH1(FormH1FormModelForReassess ass)
    {  // Step 1: Check if records already exist in FormH1Assessment table
        var existingRecords = await _repo.Formh1Assessments
            .Where(f => f.BusinessId == ass.BusinessId && f.CompanyId == ass.CompanyId && f.TaxYear == ass.TaxYear)
            .ToListAsync();

        if (existingRecords.Any())
        {
            return new ReturnObject { message = "Records already exist for the provided BusinessId, CompanyId, and TaxYear.", status = false };
        }

        // Step 2: Fetch records from SSPFiledFormH1 table based on input parameters
        var sspRecords = await _dbContext.SspfiledFormH1s
            .Where(s => s.BusinessId == ass.BusinessId.ToString() && s.CompanyId == ass.CompanyId.ToString() && s.TaxYear == ass.TaxYear)
            .ToListAsync();

        if (!sspRecords.Any())
        {
            return new ReturnObject { message = "No records found in SSPFiledFormH1 table for the provided parameters.", status = false };
        }

        // Step 3: Process fetched records and compute values
        // var assessments = new List<Formh1Assessment>();
        foreach (var sspRecord in sspRecords)
        {
            //var computed = calculatetax(sspRecord);
            //// Create a new FormH1Assessment entry
            //var assessment = new Formh1Assessment
            //{
            //    BusinessId = ass.BusinessId,
            //    CompanyId = ass.CompanyId,
            //    EmployeeId =  Convert.ToInt32(sspRecord.IndividalId),
            //    TaxYear = ass.TaxYear,
            //    Basic = sspRecord.Basic,
            //    Rent = sspRecord.Rent,
            //    Transport = sspRecord.Transport,
            //    ComputedCRA = computedCRA,
            //    TaxFreePay = taxFreePay,
            //    ComputedCI = computedCI,
            //    DateCreated = DateTime.Now,
            //    Status = "Reassess" // Default status
            //};

            //assessments.Add(assessment);
        }

        // Step 4: Insert all processed records into FormH1Assessment table
        // await _dbContext.Formh1Assessments.AddRangeAsync(assessments);
        await _dbContext.SaveChangesAsync();

        return new ReturnObject { message = "Records processed and inserted successfully." }; //data = assessments };

    }
}
