using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class GisfileParty
{
    public long Id { get; set; }

    public string? PartyExtId { get; set; }

    public string? PartyId { get; set; }

    public string? PartyTitle { get; set; }

    public string? PartyFirstName { get; set; }

    public string? PartyLastName { get; set; }

    public string? PartyMiddleName { get; set; }

    public string? PartyFullName { get; set; }

    public string? PartyType { get; set; }

    public string? PartyGender { get; set; }

    public string? PartyDob { get; set; }

    public string? PartyTin { get; set; }

    public string? PartyNin { get; set; }

    public string? PartyPhone1 { get; set; }

    public string? PartyPhone2 { get; set; }

    public string? PartyEmail { get; set; }

    public string? PartyNationality { get; set; }

    public string? PartyMaritalStatus { get; set; }

    public string? PartyOccupation { get; set; }

    public string? ContactAddress { get; set; }

    public string? PartyRelation { get; set; }

    public string? AcquisitionDate { get; set; }

    public DateTime DateSaved { get; set; }

    public long FileId { get; set; }

    public string? PageNo { get; set; }

    public string? FileNumber { get; set; }
}
