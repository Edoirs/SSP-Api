using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SelfPortalAPi.Models;
using SelfPortalAPi.NewModel;
using SelfPortalAPi.PhaseIIVm;
using System.Data;
using System.Globalization;
using EmployeesMonthlyIncome = SelfPortalAPi.Models.EmployeesMonthlyIncome;
using EmployeesMonthlySchedule = SelfPortalAPi.Models.EmployeesMonthlySchedule;
using SelfPortalAPi.Model;
using SelfPortalAPi.Vm;
using System.Runtime.Intrinsics.Arm;
using Bogus;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace SelfPortalAPi.UnitOfWork
{
    public interface IPhaseIIRepo
    {
        Task<Dictionary<List<BusinessVm>, int>> GetAllBusinessesAsync(int pageNumber, int pageSize);
        Task<Dictionary<List<BusinessRinVm>, int>> getallEmployeesCount(int pageNumber, int pageSize);
        Task<List<EmployeeIncomeVm>> GetEmployeeIncomeView(EmployeesViewFmModel emp);
        Task<List<EmployeesMonthlyIncome>> GetMonthlyIncomeAsync(EmpSchedule obj);
        Task<List<EmployeesMonthlyIncome>> GetEmployeeMonthlyIncomeAsync(EmpSchedule obj);
        Task<List<EmpScheduleDetails>> CalculateMonthScheduleAsync(EmpSchedule empSch);
        Task SaveChangesAsync();
        int CalculateMonthsLeft(string monthName);
        decimal CalculateTax(decimal ch_income, decimal gross);
        Task<List<ScheduleGetAllRes>> GetAllSchedulesAsync();
        Task<List<ScheduleGetViewRes>> GetSchedulesViewAsync(EmpSchFm empSch);
        Task<List<AssessmentRDMRes>> GetAssessmentRDMAsync(BusSchFm1 obj);
        Task<List<Models.AssetTaxPayerDetailsApi>> GetBusinessDetails(string BusinessRin, string CompanyRin);
        Task<List<EmployeesMonthlySchedule>> GetAssessmentSchudeleDetails(EmpMtAss ass);
        Task<List<EmployeesMonthlySchedule>> GetAssessmentScheduleDetails2(EmpMtAss ass);
        Task<List<EmployeesMonthlySchedule>> GetAssessmentSchudeleDetailsDownLoad(EmpMtAss ass);
    }

    public class PhaseIIRepo : IPhaseIIRepo
    {
        private readonly IMapper _mapper;
        private readonly SelfServiceConnect _dbContext;


        public PhaseIIRepo(IMapper mapper, SelfServiceConnect dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<Dictionary<List<BusinessVm>, int>> GetAllBusinessesAsync(int pageNumber, int pageSize)
        {
            var query =  _dbContext.AssetTaxPayerDetailsApis
                   .Select(o => new BusinessVm
                   {
                       BusinessRin = o.AssetRin,
                       BusinessName = o.AssetName,
                       CompanyRin = o.TaxPayerRinnumber,
                       LgaName = o.AssetAddress,
                   });

            int totalCount =await  query.CountAsync();
            var pageRes =await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return new Dictionary<List<BusinessRinVm>, int> 
            {
                {pageRes,totalCount }
            };
        }

        public async Task<Dictionary<List<BusinessRinVm>, int >> getallEmployeesCount(int pageNumber, int pageSize)
        {
            var query = from asset in _dbContext.AssetTaxPayerDetailsApis
                        join employee in _dbContext.EmployeesMonthlyIncomes
                        on asset.AssetId.ToString() equals employee.BusinessId
                        group asset by new { asset.AssetRin, asset.AssetName, asset.AssetAddress, asset.AssetLga, asset.TaxPayerRinnumber } into g
                        select new BusinessRinVm
                        {
                            businessRin = g.Key.AssetRin,
                            CompanyRin = g.Key.TaxPayerRinnumber,
                            businessName = g.Key.AssetName,
                            businessAddress = g.Key.AssetAddress,
                            businessLga = g.Key.AssetLga,
                            NoOfEmployees = g.Count()
                        };
            int totalCount = await query.CountAsync();
            var pageRes= await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return new Dictionary<List<BusinessRinVm>, int> {
                {pageRes,totalCount }
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
                             i.Firstname,
                             i.Surname,
                             i.EmployeeRin,
                             e.Status
                         } into g
                         select new EmployeeIncomeVm
                         {
                             EmployeeRin = g.Key.EmployeeRin,
                             FullName = g.Key.Firstname + " " + g.Key.Surname,
                             TotalIncome = (decimal)g.Sum(x => x.e.Basic + x.e.Rent + x.e.Transport + x.e.Ltg + x.e.Utility + x.e.Meal + x.e.Others + x.e.Nhf + x.e.Nhis + x.e.Pension + x.e.LifeAssurance),
                             Non_TaxableIncome = (decimal)g.Sum(x => x.e.Pension + x.e.Nhf + x.e.Nhis + x.e.LifeAssurance),
                             GrossIncome = (decimal)g.Sum(x => (x.e.Basic + x.e.Rent + x.e.Transport + x.e.Ltg + x.e.Utility + x.e.Meal + x.e.Others + x.e.Nhf + x.e.Nhis + x.e.Pension + x.e.LifeAssurance) - (x.e.Pension + x.e.Nhf + x.e.Nhis + x.e.LifeAssurance)),
                             Status = (bool)g.Key.Status ? "Active" : "Inactive",

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
            var result = from e in _dbContext.EmployeesMonthlyIncomes
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
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
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

        public async Task<List<ScheduleGetAllRes>> GetAllSchedulesAsync()
        {
            var query = from s in _dbContext.EmployeesMonthlySchedules
                        join n in _dbContext.Individuals on s.EmployeeRin equals n.EmployeeRin into sn
                        from n in sn.DefaultIfEmpty()
                        join i in _dbContext.EmployeesMonthlyIncomes on n.EmployeeId equals i.EmployeeId into ni
                        from i in ni.DefaultIfEmpty()
                        join a in _dbContext.AssetTaxPayerDetailsApis on new { s.BusinessId, s.EmployerId } equals new { BusinessId = a.AssetId.ToString(), EmployerId = a.TaxPayerId.ToString() } into sa
                        from a in sa.DefaultIfEmpty()
                        group new { s, i, a } by new { a.AssetName, a.AssetRin, a.TaxPayerRinnumber } into g
                        select new ScheduleGetAllRes
                        {
                            BusinessRin = g.Key.AssetRin,
                            CompanyRin = g.Key.TaxPayerRinnumber,
                            BusinessName = g.Key.AssetName,
                            TaxMonth = g.Min(x => x.s.TaxMonth).ToString(),
                            TaxYear = g.Min(x => x.s.TaxYear),
                            EmployeeCount = g.Count(x => x.s.EmployeeRin != null),
                            TotalIncome = g.Sum(x => (x.i.Basic + x.i.Rent + x.i.Transport + x.i.Ltg + x.i.Utility + x.i.Meal + x.i.Others + x.i.Nhf + x.i.Nhis + x.i.Pension + x.i.LifeAssurance)),
                            MonthlyTax = g.Sum(x =>x.s.Tax), 
                            DateForwarded = g.Min(x => x.s.CreatedDate),
                            AssessementStatus = g.Min(x => x.s.AssessementStatusId) == 1 ? "Approved" : g.Min(x => x.s.AssessementStatusId) == 2 ? "Awaiting Approval" : "Re-Assessed"
                        };

            return await query.ToListAsync();
        }

        public async Task<List<ScheduleGetViewRes>> GetSchedulesViewAsync(EmpSchFm empSch)
        {
            var result = from s in _dbContext.EmployeesMonthlySchedules
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
                         };

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
                        where s.BusinessId == obj.BusinessId && s.EmployerId == obj.CompanyId && s.AssessementStatusId == 2
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
                var assessmentRulesQuery = from ar in _dbContext.AssessmentRules
                                           where ar.TaxYear == obj.TaxYear && ar.AssessmentRuleName.Contains(obj.TaxMonth)
                                           select new
                                           {
                                               Profile = ar.Profile,
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

        public async Task<List<EmployeesMonthlySchedule>> GetAssessmentScheduleDetails2(EmpMtAss ass)
        {
            // Retrieve the asset and tax payer details
            var getId = await _dbContext.AssetTaxPayerDetailsApis
                .FirstOrDefaultAsync(x => x.AssetRin == ass.BusinessRin && x.TaxPayerRinnumber == ass.CompanyRin);

            if (getId == null)
            {
                throw new System.Exception("Asset or Tax Payer details not found.");
            }

            // Retrieve the employee monthly schedules
            var buss = await _dbContext.EmployeesMonthlySchedules
                .Where(e => e.BusinessId == getId.AssetId.ToString() &&
                            e.EmployerId == getId.TaxPayerId.ToString() &&
                            e.TaxMonth == ass.TaxMonth &&
                            e.TaxYear == ass.TaxYear)
                .ToListAsync();

            // Check assessment status
            if (buss.Any(e => e.AssessementStatusId == 1))
            {
                throw new System.Exception("Assessment Cannot Be Deleted Because It Is Already Approved. Use Re-Assess Option");
            }
            else if (buss.Any(e => e.AssessementStatusId == 2))
            {
                buss = buss.Select(e => new SelfPortalAPi.Models.EmployeesMonthlySchedule
                {
                    EmployeeRin = getId.TaxPayerRinnumber,
                    BusinessId = e.BusinessId,
                    EmployerId = e.EmployerId,
                    TaxMonth = e.TaxMonth,
                    TaxYear = e.TaxYear ?? 0
                }).ToList();
            }

            return buss;
        }

        public async Task<List<EmployeesMonthlySchedule>> GetAssessmentSchudeleDetailsDownLoad(EmpMtAss ass)
        {
            var getId = await _dbContext.AssetTaxPayerDetailsApis.
                        FirstOrDefaultAsync(x => x.AssetRin == ass.BusinessRin && x.TaxPayerRinnumber == ass.CompanyRin);

            var buss = await _dbContext.EmployeesMonthlySchedules
                .Where(e => e.BusinessId == getId.AssetId.ToString() &&
                            e.EmployerId == getId.TaxPayerId.ToString() &&
                            e.TaxMonth == ass.TaxMonth &&
                            e.TaxYear == ass.TaxYear &&
                            e.AssessementStatusId == 1)
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

    }
}


