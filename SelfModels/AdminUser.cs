using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class AdminUser
{
//    public int AdminUserId { get; set; }

//    public int TaxOfficeId { get; set; }
//    public string TaxOfficeName { get; set; }
//    public string? AdminUserTypeName { get; set; }

//    public int PayeUserTypeId { get; set; }

//    public int RoleId { get; set; }

//    public string? Password { get; set; }

//    public string? Username { get; set; }

//    public string? Email { get; set; }

//    public string? ContactName { get; set; }

//    public string? Designation { get; set; }

//    public string? Phone { get; set; }

//    public byte IsActive { get; set; }

//    public string? ModifiedBy { get; set; }

//    public DateTime? ModifiedDate { get; set; }

//    public string? CreatedBy { get; set; }

//    public DateTime? CreateddDate { get; set; }
//}

    public int AdminUserId { get; set; }

public string? AdminUserTypeName { get; set; }

public int PayeUserTypeId { get; set; }

public int RoleId { get; set; }

public string? Password { get; set; }

public string? Username { get; set; }

public string? Email { get; set; }

public string? ContactName { get; set; }

public string? Designation { get; set; }

public string? Phone { get; set; }

public byte IsActive { get; set; }

public string? ModifiedBy { get; set; }

public DateTime? ModifiedDate { get; set; }

public string? CreatedBy { get; set; }

public DateTime? CreateddDate { get; set; }

public int? TaxOfficeId { get; set; }

public string TaxOfficeName { get; set; } = null!;
}



public partial class AdminUserMain 
{
    public int UserID { get; set; }
    public int UserTypeID { get; set; }
    public string UserTypeName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string ContactName { get; set; }
    public string EmailAddress { get; set; }
    public string ContactNumber { get; set; }
    public bool Active { get; set; }
    public string ActiveText { get; set; }
    public bool IsTOManager { get; set; }
    public string IsTOManagerText { get; set; }
    public int TaxOfficeID { get; set; }
    public string TaxOfficeName { get; set; }
    public object TOManagerID { get; set; }
    public object TOManagerName { get; set; }
    public object SignaturePath { get; set; }
    public bool IsDirector { get; set; }
    public string IsDirectorText { get; set; }

}
