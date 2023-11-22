using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class EpldBusiness
{
    public long Epldid { get; set; }

    public int? DataSourceId { get; set; }

    public long? DsrefId { get; set; }

    public string? RegisteredName { get; set; }

    public int? BusinessTypeId { get; set; }

    public string? BusinessTypename { get; set; }

    public int? Lgaid { get; set; }

    public string? Lganame { get; set; }

    public int? BusinessCategoryId { get; set; }

    public string? BusinessCategoryName { get; set; }

    public int? BusinessSectorId { get; set; }

    public string? BusinessSectorName { get; set; }

    public int? BusinessSubSectorId { get; set; }

    public string? BusinessSubSectorName { get; set; }

    public int? BusinessStructureId { get; set; }

    public string? BusinessStructureName { get; set; }

    public int? BusinessOperationId { get; set; }

    public string? BusinessOperationName { get; set; }

    public int? SizeId { get; set; }

    public string? SizeName { get; set; }

    public string? ContactName { get; set; }

    public string? BusinessNumber { get; set; }

    public string? BusinessAddress { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public int? TaxPayerRoleId { get; set; }

    public string? TaxPayerRoleName { get; set; }

    public int? IndGenderId { get; set; }

    public string? IndGenderName { get; set; }

    public int? IndTitleId { get; set; }

    public string? IndTitleName { get; set; }

    public string? IndFirstName { get; set; }

    public string? IndMiddleName { get; set; }

    public string? IndLastName { get; set; }

    public DateTime? IndDateOfBirth { get; set; }

    public string? IndTin { get; set; }

    public string? IndPhoneNo1 { get; set; }

    public string? IndPhoneNo2 { get; set; }

    public string? IndEmailAddress { get; set; }

    public int? IndTaxofficeid { get; set; }

    public string? IndTaxofficeName { get; set; }

    public int? IndMaritalstatusid { get; set; }

    public string? IndMaritalstatusName { get; set; }

    public int? IndNationalityid { get; set; }

    public string? IndNationalityName { get; set; }

    public int? IndEconomicActivityId { get; set; }

    public string? IndEconomicActivityName { get; set; }

    public int? IndNotificationid { get; set; }

    public string? IndNotificationName { get; set; }

    public string? CompName { get; set; }

    public string? CompTin { get; set; }

    public string? CompPhoneNo1 { get; set; }

    public string? CompPhoneNo2 { get; set; }

    public string? CompEmailAddress { get; set; }

    public int? CompTaxofficeid { get; set; }

    public string? CompTaxofficeName { get; set; }

    public string? CompCacRegistrationnumber { get; set; }

    public int? CompEconomicActivityId { get; set; }

    public string? CompEconomicActivityName { get; set; }

    public int? CompNotificationid { get; set; }

    public string? CompNotificationName { get; set; }

    public string? RecordStatus { get; set; }

    public string? RecordResult { get; set; }

    public string? Rin { get; set; }
}
