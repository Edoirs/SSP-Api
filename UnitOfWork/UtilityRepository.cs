using Azure.Core;
using SelfPortalAPi.Model;
using System.Text.Json;
using static SelfPortalAPi.Model.DTO;

namespace SelfPortalAPi.UnitOfWork
{
    public interface IUtilityRepository
    {
        Task<ReturnObject> GetGender();

        Task<ReturnObject> GetTitle();

        Task<ReturnObject> GetTaxOffice();

        Task<ReturnObject> GetLGA();

        Task<ReturnObject> GetZone();

        Task<ReturnObject> GetNationality();

        Task<ReturnObject> GetEconomicActivity();

        Task<ReturnObject> GetBusinessType();

        Task<ReturnObject> GetBusinessCategory();

        Task<ReturnObject> GetBusinessSector();

        Task<ReturnObject> GetBusinessSubSector();

        Task<ReturnObject> GetBusinessStructure();

        Task<ReturnObject> GetBusinessOperation();
    }

    public class UtilityRepository : IUtilityRepository
    {
        private readonly ApiDbContext _db;
        private readonly EirsContext _context;

        public UtilityRepository(ApiDbContext db, EirsContext context)
        {
            _db = db;
            _context = context;
        }

        public async Task<ReturnObject> GetBusinessCategory()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.BusinessCategories
                               join c in _db.BusinessTypes
                               on b.BusinessTypeId equals c.BusinessTypeId
                               select new
                               {
                                   b.BusinessTypeId,
                                   c.BusinessTypeName,
                                   b.BusinessCategoryId,
                                   b.BusinessCategoryName
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetBusinessOperation()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.BusinessOperations
                               join c in _db.BusinessTypes
                               on b.BusinessTypeId equals c.BusinessTypeId
                               select new
                               {
                                   b.BusinessTypeId,
                                   c.BusinessTypeName,
                                   b.BusinessOperationId,
                                   b.BusinessOperationName
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetBusinessSector()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";

            //var data = await (from b in _db.BusinessSectors
            //                  join c in _db.BusinessTypes on b.BusinessTypeId equals c.BusinessTypeId
            //                  join d in _db.BusinessCategories on b.BusinessCategoryId equals d.BusinessCategoryId
            //                  select new DTO.BusinessSectorDTO
            //                  {
            //                      BusinessTypeId = (int)b.BusinessTypeId,
            //                      BusinessTypeName = c.BusinessTypeName,
            //                      BusinessSectorId = b.BusinessSectorId,
            //                      BusinessSectorName = b.BusinessSectorName,
            //                      BusinessCategoryId = d.BusinessCategoryId,
            //                      BusinessCategoryName = d.BusinessCategoryName
            //                  }).ToListAsync();
            var sql = @"
                      SELECT b.BusinessTypeId,
                          c.BusinessTypeName,
                          b.BusinessSectorId,
                          b.BusinessSectorName,
                          d.BusinessCategoryId,
                          d.BusinessCategoryName
                      FROM BusinessSectors b
                      JOIN BusinessTypes c ON b.BusinessTypeId = c.BusinessTypeId
                      JOIN BusinessCategories d ON b.BusinessCategoryId = d.BusinessCategoryId
                  ";
            var data = _context.BusinessSectors.FromSqlRaw(sql)
            .Select(result => new DTO.BusinessSectorDTO
            {
                BusinessTypeId = result.BusinessSectorId,
                //BusinessTypeName = result.BusinessTypee,
                BusinessSectorId = result.BusinessSectorId,
                BusinessSectorName = result.BusinessSectorName,
                BusinessCategoryId = (int)result.BusinessCategoryId,
                //BusinessCategoryName = result.BusinessCategoryName
            })
      .ToListAsync();

            resp.data = data;
            return resp;
        }

        public async Task<ReturnObject> GetBusinessStructure()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.BusinessStructures
                               join c in _db.BusinessTypes
                               on b.BusinessTypeId equals c.BusinessTypeId
                               select new
                               {
                                   b.BusinessTypeId,
                                   c.BusinessTypeName,
                                   b.BusinessStructureId,
                                   b.BusinessStructureName
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetBusinessSubSector()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.BusinessSubSectors
                               join c in _db.BusinessSectors
                               on b.BusinessSectorId equals c.BusinessSectorId
                               select new
                               {
                                   b.BusinessSectorId,
                                   c.BusinessSectorName,
                                   b.BusinessSubSectorName,
                                   b.BusinessSubSectorId
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetBusinessType()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.BusinessTypes
                               select new
                               {
                                   b.BusinessTypeId,
                                   b.BusinessTypeName
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetEconomicActivity()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.TaxPayerTypes
                               join c in _db.EconomicActivities
                               on b.TaxPayerTypeId equals c.TaxPayerTypeId
                               select new
                               {
                                   b.TaxPayerTypeId,
                                   b.TaxPayerTypeName,
                                   c.EconomicActivitiesId,
                                   c.EconomicActivitiesName
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetGender()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.Genders
                               select new
                               {
                                   b.GenderId,
                                   b.GenderName
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetLGA()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.Lgas
                               select new
                               {
                                   b.Lgaid,
                                   b.Lganame
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetNationality()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.Nationalities
                               select new
                               {
                                   b.NationalityId,
                                   b.NationalityName
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetTaxOffice()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.TaxOffices
                               join c in _db.Zones
                               on b.ZoneId equals c.ZoneId
                               select new
                               {
                                   b.TaxOfficeId,
                                   b.TaxOfficeName,
                                   c.ZoneId,
                                   c.ZoneName
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetTitle()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.Titles
                               select new
                               {
                                   b.TitleId,
                                   b.TitleName
                               }).ToListAsync();
            return resp;
        }

        public async Task<ReturnObject> GetZone()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            resp.data = await (from b in _db.Lgas
                               join c in _db.Zones
                               on b.Lgaid equals c.LgaId
                               select new
                               {
                                   b.Lgaid,
                                   b.Lganame,
                                   c.ZoneId,
                                   c.ZoneName
                               }).ToListAsync();
            return resp;
        }
    }
}