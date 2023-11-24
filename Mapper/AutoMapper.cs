using AutoMapper;
using SelfPortalAPi.FormModel;
using SelfPortalAPi.NewTables;

namespace SelfPortalAPi.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<AddEmployee, employee>();
            CreateMap<EmployeeVm, employee>();
            CreateMap<ProjectionFm, Projection>();
        }
    }
}
