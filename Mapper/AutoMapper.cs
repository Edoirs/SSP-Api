using Profile = AutoMapper.Profile;

namespace SelfPortalAPi.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<AddEmployee, Employee>();
            CreateMap<AddEmployeesInd, Individual>();
            CreateMap<AnnualReturnFm, AnnualReturn>();
           // CreateMap<BusinessViewModel,Bus >();
            //CreateMap<Business,BusinessFormModel>();
           
            CreateMap<Employee,EmployeeVm>();
            CreateMap<SspfiledFormH1, SspformH1>();
            CreateMap<SspformH3, SspfiledFormH3>();
            CreateMap<SspfiledFormH3, SspformH3>();
            CreateMap<SspformH1, SspfiledFormH1>();
            CreateMap<ProjectionFm,Projection>();
            //CreateMap<ScheduleFm,Schedule>();
            //CreateMap<Schedule_RecordFm,Schedule_Record>();
        }
    }
}
