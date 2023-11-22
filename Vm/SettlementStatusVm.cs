
using FluentValidation;

namespace SelfPortalAPi.Vm
{
    public class SettlementStatusVm
    {
        public string? SettlementStatus1 { get; set; }

        public string? StatusDescription { get; set; } 

        public class Validator : AbstractValidator<SettlementStatusVm>
        {
            public Validator()
            {
                RuleFor(x => x.SettlementStatus1).NotEmpty();
                RuleFor(x => x.StatusDescription).NotEmpty();
            }
        }
    }
}
