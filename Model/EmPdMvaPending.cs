using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class EmPdMvaPending
{
    public long Pdmvpid { get; set; }

    public int? TaxYear { get; set; }

    public int? TaxMonth { get; set; }

    public string? PaymentRefNumber { get; set; }

    public string? PaymentDateTime { get; set; }

    public string? AssessmentReference { get; set; }

    public string? ReceiptNo { get; set; }

    public string? Rin { get; set; }

    public string? CustomerName { get; set; }

    public string? RevenueItem { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public string? DepositSlip { get; set; }

    public string? ChequeValueDate { get; set; }

    public string? Bank { get; set; }

    public string? AdditionalInfo { get; set; }

    public string? BankBranch { get; set; }

    public string? TaxPayerType { get; set; }

    public string? PaymentCode { get; set; }

    public string? RetrievalRefNumber { get; set; }

    public string? AuthId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
