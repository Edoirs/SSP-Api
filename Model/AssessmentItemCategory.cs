using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class AssessmentItemCategory
{
    public int AssessmentItemCategoryId { get; set; }

    public string? AssessmentItemCategoryName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentItemSubCategory> AssessmentItemSubCategories { get; set; } = new List<AssessmentItemSubCategory>();

    public virtual ICollection<AssessmentItem> AssessmentItems { get; set; } = new List<AssessmentItem>();

    public virtual ICollection<MdaServiceItem> MdaServiceItems { get; set; } = new List<MdaServiceItem>();
}
