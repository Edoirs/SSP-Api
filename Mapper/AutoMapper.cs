using AutoMapper;
using SelfPortalAPi.FormModel;
using SelfPortalAPi.testingModel;
using Profile = AutoMapper.Profile;

namespace SelfPortalAPi.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<AddEmployee, employee>();
            CreateMap<AnnualReturnFm, AnnualReturn>();
            CreateMap<BusinessViewModel,Business >();
            CreateMap<Business,BusinessFormModel>();
           
            CreateMap<employee,EmployeeVm>();
            CreateMap<ProjectionFm,Projection>();
            CreateMap<ScheduleFm,Schedule>();
            CreateMap<Schedule_RecordFm,Schedule_Record>();
        }
    }
}
