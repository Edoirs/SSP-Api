using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class MstUser
{
    public int UserId { get; set; }

    public int? UserTypeId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? ContactName { get; set; }

    public string? EmailAddress { get; set; }

    public string? ContactNumber { get; set; }

    public bool? Active { get; set; }

    public DateTime? LastLogin { get; set; }

    public int? FailedLoginCount { get; set; }

    public bool? IsTomanager { get; set; }

    public int? TaxOfficeId { get; set; }

    public int? TomanagerId { get; set; }

    public string? SignaturePath { get; set; }

    public bool? IsDirector { get; set; }

    public int? AgencyId { get; set; }

    public string? Title { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapApiUsersRight> MapApiUsersRights { get; set; } = new List<MapApiUsersRight>();

    public virtual ICollection<MapUserScreen> MapUserScreens { get; set; } = new List<MapUserScreen>();

    public virtual ICollection<MstUserToken> MstUserTokens { get; set; } = new List<MstUserToken>();

    public virtual MstUserType? UserType { get; set; }
}
