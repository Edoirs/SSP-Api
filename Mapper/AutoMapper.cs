using AutoMapper;
using SelfPortalAPi.FormModel;
using SelfPortalAPi.NewTables;

namespace SelfPortalAPi.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<employee, AddEmployee>();
            CreateMap<employee, EmployeeVm>();
            CreateMap<Projection, ProjectionFm>();
        }
    }
}
