using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class ScheduleRecord
{
    public int Id { get; set; }

    public int GrossIncome { get; set; }

    public int Nhis { get; set; }

    public int Nhf { get; set; }

    public int Pension { get; set; }

    public float Cra { get; set; }

    public int EmployeeId { get; set; }

    public int ScheduleId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int TotalIncome { get; set; }

    public int LifeAssurance { get; set; }

    public string UniqueId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public long CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public long ModifiedBy { get; set; }
}
