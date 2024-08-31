//namespace SelfPortalAPi.Vm
//{
//    using QuestPDF.Drawing;
//    using QuestPDF.Fluent;
//    using QuestPDF.Helpers;
//    using QuestPDF.Infrastructure;

//    public class PdfDocument : IDocument
//    {
//        private readonly List<Schedulepdf> _scheduleData;
//        private readonly List<CompDetailsRes> _companyDetails;
//        private readonly List<BusDetailsRes> _businessDetails;

//        public PdfDocument(List<Schedulepdf> scheduleData, List<CompDetailsRes> companyDetails, List<BusDetailsRes> businessDetails)
//        {
//            _scheduleData = scheduleData;
//            _companyDetails = companyDetails;
//            _businessDetails = businessDetails;
//        }

//        public DocumentMetadata Metadata => new DocumentMetadata
//        {
//            Title = "PAYE Tax Analysis",
//            Author = "EIRS"
//        };

//        public void Compose(IDocumentContainer container)
//        {
//            container
//                .Page(page =>
//                {
//                    page.Margin(50);
//                    page.Content()
//                        .Column(column =>
//                        {
//                            column.Item().Text("EDO STATE INTERNAL REVENUE SERVICE", TextStyle.Bold).AlignCenter();
//                            column.Item().Text("80, NEW LAGOS ROAD, BENIN CITY", TextStyle.Bold).AlignCenter();

//                            column.Item().PaddingVertical(10).Table(table =>
//                            {
//                                table.ColumnsDefinition(columns =>
//                                {
//                                    columns.ConstantColumn(70);
//                                    columns.RelativeColumn();
//                                    columns.ConstantColumn(70);
//                                });

//                                table.Header(header =>
//                                {
//                                    header.Cell().Image("https://pinscher.eirs.gov.ng/spike/logo/coat_of_arm.png");
//                                    header.Cell().Text("EDO STATE INTERNAL REVENUE SERVICE\n80, NEW LAGOS ROAD, BENIN CITY").AlignCenter();
//                                    header.Cell().Image("https://pinscher.eirs.gov.ng/spike/logo/eirs_logo.png");
//                                });

//                                table.Cell().Text($"TAXPAYER NAME: {GetValue(_companyDetails.FirstOrDefault()?.TaxpayerName)}");
//                                table.Cell().Text($"BUSINESS NAME: {GetValue(_companyDetails.FirstOrDefault()?.BusinessName)}");
//                                table.Cell().Text($"ADDRESS: {GetValue(_companyDetails.FirstOrDefault()?.BusinessAddress)}");

//                                table.Cell().Text($"TAX PAYER RIN: {GetValue(_businessDetails.FirstOrDefault()?.TaxpayerRin)}");
//                                table.Cell().Text($"BUSINESS RIN: {GetValue(_businessDetails.FirstOrDefault()?.BusinessRin)}");
//                                table.Cell().Text($"PHONE: {GetValue(_businessDetails.FirstOrDefault()?.BusinessPhone)}");
//                            });

//                            column.Item().PaddingTop(20).Table(table =>
//                            {
//                                table.ColumnsDefinition(columns =>
//                                {
//                                    columns.ConstantColumn(30);
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                    columns.RelativeColumn();
//                                });

//                                table.Header(header =>
//                                {
//                                    header.Cell().Text("S/NO.").Bold();
//                                    header.Cell().Text("RIN").Bold();
//                                    header.Cell().Text("Name").Bold();
//                                    header.Cell().Text("Tax Month").Bold();
//                                    header.Cell().Text("Tax Year").Bold();
//                                    header.Cell().Text("Gross").Bold();
//                                    header.Cell().Text("CRA").Bold();
//                                    header.Cell().Text("Pension").Bold();
//                                    header.Cell().Text("NHF").Bold();
//                                    header.Cell().Text("NHIS").Bold();
//                                    header.Cell().Text("Tax Free Pay").Bold();
//                                    header.Cell().Text("Ch. Income").Bold();
//                                    header.Cell().Text("Tax").Bold();
//                                });

//                                foreach (var item in _scheduleData)
//                                {
//                                    table.Row(row =>
//                                    {
//                                        row.Cell().Text(item.Rin.ToString());
//                                        row.Cell().Text(item.Name);
//                                        row.Cell().Text(item.TaxMonth.ToString());
//                                        row.Cell().Text(item.TaxYear.ToString());
//                                        row.Cell().Text(item.Gross.ToString("C"));
//                                        row.Cell().Text(item.Cra.ToString("C"));
//                                        row.Cell().Text(item.Pension.ToString("C"));
//                                        row.Cell().Text(item.Nhf.ToString("C"));
//                                        row.Cell().Text(item.Nhis.ToString("C"));
//                                        row.Cell().Text(item.Tfp.ToString("C"));
//                                        row.Cell().Text(item.Ci.ToString("C"));
//                                        row.Cell().Text(item.Tax.ToString("C"));
//                                    });
//                                }
//                            });
//                        });
//                });
//        }

//        private static string GetValue(string? value) => value ?? string.Empty;
//    }

//}
