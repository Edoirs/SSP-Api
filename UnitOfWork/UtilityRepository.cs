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
        private readonly SelfServiceConnect _db;
        //private readonly EirsContext _context;

        private readonly IOptions<ConnectionStrings> _serviceSettings;
        public UtilityRepository(SelfServiceConnect db, IOptions<ConnectionStrings> serviceSettings)
        {
            _db = db;
            _serviceSettings = serviceSettings;
            //  _context = context;
        }
        public async Task<ReturnObject> GetBusinessCategory()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.BusinessCategories
            //                   join c in _db.BusinessTypes
            //                   on b.BusinessTypeId equals c.BusinessTypeId
            //                   select new
            //                   {
            //                       b.BusinessTypeId,
            //                       c.BusinessTypeName,
            //                       b.BusinessCategoryId,
            //                       b.BusinessCategoryName
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetBusinessOperation()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.BusinessOperations
            //                   join c in _db.BusinessTypes
            //                   on b.BusinessTypeId equals c.BusinessTypeId
            //                   select new
            //                   {
            //                       b.BusinessTypeId,
            //                       c.BusinessTypeName,
            //                       b.BusinessOperationId,
            //                       b.BusinessOperationName
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetBusinessSector()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.BusinessSectors
            //                   join c in _db.BusinessTypes
            //                   on b.BusinessTypeId equals c.BusinessTypeId
            //                   join d in _db.BusinessCategories
            //                   on b.BusinessCategoryId equals d.BusinessCategoryId
            //                   select new
            //                   {
            //                       b.BusinessTypeId,
            //                       c.BusinessTypeName,
            //                       b.BusinessSectorId,
            //                       b.BusinessSectorName,
            //                       d.BusinessCategoryId,
            //                       d.BusinessCategoryName

            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetBusinessStructure()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.BusinessStructures
            //                   join c in _db.BusinessTypes
            //                   on b.BusinessTypeId equals c.BusinessTypeId
            //                   select new
            //                   {
            //                       b.BusinessTypeId,
            //                       c.BusinessTypeName,
            //                       b.BusinessStructureId,
            //                       b.BusinessStructureName           
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetBusinessSubSector()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.BusinessSubSectors
            //                   join c in _db.BusinessSectors
            //                   on b.BusinessSectorId equals c.BusinessSectorId
            //                   select new
            //                   {
            //                       b.BusinessSectorId,
            //                       c.BusinessSectorName,
            //                       b.BusinessSubSectorName,
            //                       b.BusinessSubSectorId
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetBusinessType()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.BusinessTypes
            //                   select new
            //                   {
            //                       b.BusinessTypeId,
            //                       b.BusinessTypeName
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetEconomicActivity()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.TaxPayerTypes
            //                   join c in _db.EconomicActivities
            //                   on b.TaxPayerTypeId equals c.TaxPayerTypeId
            //                   select new
            //                   {
            //                       b.TaxPayerTypeId,
            //                       b.TaxPayerTypeName,
            //                       c.EconomicActivitiesId,
            //                       c.EconomicActivitiesName
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetGender()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.Genders
            //                   select new
            //                   {
            //                       b.GenderId,
            //                       b.GenderName
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetLGA()
        {

            AllFunction al = new();
            JavaScriptSerializer js = new();
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";

            string baseUrl = _serviceSettings.Value.ErasBaseUrl;

            var token = al.GetToken(_serviceSettings.Value.ErasBaseUrl, _serviceSettings.Value.eirsusername, _serviceSettings.Value.eirspassword);
            if (token != null)
            {
                baseUrl = baseUrl + "User/LGAs";
                var respApi = await al.CallAPi(baseUrl, token, "get", "");
                var rootobjectVm = js.Deserialize<RootobjectAPI>(respApi);
                resp.data = rootobjectVm.Result;
                resp.status = rootobjectVm.Success;
                resp.message = rootobjectVm.Message;
            }
            return resp;
        }
        public async Task<ReturnObject> GetNationality()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.Nationalities
            //                   select new
            //                   {
            //                       b.NationalityId,
            //                       b.NationalityName
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetTaxOffice()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.TaxOffices
            //                   join c in _db.Zones
            //                   on b.ZoneId equals c.ZoneId
            //                   select new
            //                   {
            //                       b.TaxOfficeId,
            //                       b.TaxOfficeName,
            //                       c.ZoneId,
            //                       c.ZoneName
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetTitle()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.Titles
            //                   select new
            //                   {
            //                       b.TitleId,
            //                       b.Title1
            //                   }).ToListAsync();
            return resp;
        }
        public async Task<ReturnObject> GetZone()
        {
            var resp = new ReturnObject();
            resp.status = true;
            resp.message = "record pulled successfully";
            //resp.data = await (from b in _db.Lgas
            //                   join c in _db.Zones
            //                   on b.Lgaid equals c.LgaId
            //                   select new
            //                   {
            //                       b.Lgaid,
            //                       b.Lganame,
            //                       c.ZoneId,
            //                       c.ZoneName
            //                   }).ToListAsync();
            return resp;
        }
    }
}