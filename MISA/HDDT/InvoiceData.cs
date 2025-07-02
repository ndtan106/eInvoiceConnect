using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace eInvoiceConnect.MISA.HDDT
{
    /// <summary>
    /// Thông tin dữ liệu hđ thô
    /// </summary>
    public class InvoiceData
    {
        #region Thông tin chung
        /// <summary>
        /// ID của hóa đơn trên Client App
        /// </summary>
        public string RefID { get; set; }

        /// <summary>
        /// Ký hiệu hóa đơn
        /// </summary>
        public string InvSeries { get; set; }

        /// <summary>
        /// Tên hóa đơn
        /// </summary>
        public string InvoiceName { get; set; }

        /// <summary>
        /// Ngày hóa đơn
        /// </summary>
        /// <returns></returns>
        public System.DateTime InvDate { get; set; }

        /// <summary>
        /// Mã loại tiền tệ
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Tỷ giá
        /// </summary>
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Hình thức thanh toán
        /// </summary>
        public string PaymentMethodName { get; set; }

        /// <summary>
        /// Là hóa đơn gửi dạng bảng tổng hợp
        /// </summary>
        public bool IsInvoiceSummary { get; set; }
        #endregion

        #region Thông tin liên quan hóa đơn gốc của HĐ thay thế/điều chỉnh
        /// <summary>
        /// Tính chất hóa đơn (1: thay thế; 2: điều chỉnh)
        /// </summary>
        public int? ReferenceType { get; set; }

        /// <summary>
        /// Loại hóa đơn bị thay thế/điều chỉnh (1: Hóa đơn NĐ 123; 3: Hóa đơn NĐ 51)
        /// </summary>
        public int? OrgInvoiceType { get; set; }

        /// <summary>
        /// Ký hiệu mẫu hđ bị thay thế/điều chỉnh
        /// </summary>
        public string OrgInvTemplateNo { get; set; }

        /// <summary>
        /// Ký hiệu hđ bị thay thế/điều chỉnh
        /// </summary>
        public string OrgInvSeries { get; set; }

        /// <summary>
        /// Số hđ bị thay thế/điều chỉnh
        /// </summary>
        public string OrgInvNo { get; set; }

        /// <summary>
        /// Ngày hóa đơn bị thay thế/điều chỉnh
        /// </summary>
        public System.DateTime? OrgInvDate { get; set; }

        /// <summary>
        /// Ghi chú của hóa đơn
        /// </summary>
        public string InvoiceNote { get; set; }
        #endregion

        #region Thông tin người bán
        /// <summary>
        /// Tên người bán
        /// </summary>
        public string SellerLegalName { get; set; }

        /// <summary>
        /// MST người bán
        /// </summary>
        public string SellerTaxCode { get; set; }

        /// <summary>
        /// Địa chỉ người bán
        /// </summary>
        public string SellerAddress { get; set; }

        /// <summary>
        /// ĐT người bán
        /// </summary>
        public string SellerPhoneNumber { get; set; }

        /// <summary>
        /// Email người bán
        /// </summary>
        public string SellerEmail { get; set; }

        /// <summary>
        /// Số TK ngân hàng người bán
        /// </summary>
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// Tên ngân hàng người bán
        /// </summary>
        public string SellerBankName { get; set; }

        /// <summary>
        /// Fax người bán
        /// </summary>
        public string SellerFax { get; set; }

        /// <summary>
        /// Website người bán
        /// </summary>
        public string SellerWebsite { get; set; }
        #endregion

        #region Thông tin liên quan PXK
        /// <summary>
        /// Tên (Tên người xuất hàng)
        /// </summary>
        public string StockOutLegalName { get; set; }

        /// <summary>
        /// Mã số thuế (MST người xuất hàng)
        /// </summary>
        public string StockOutTaxCode { get; set; }

        /// <summary>
        /// Lệnh điều động nội bộ
        /// </summary>
        public string InternalCommand { get; set; }

        /// <summary>
        /// Địa chỉ (Địa chỉ kho xuất hàng)
        /// </summary>
        public string StockOutAddress { get; set; }

        /// <summary>
        /// Họ và tên người xuất hàng
        /// </summary>
        public string StockOutFullName { get; set; }

        /// <summary>
        /// Tên người vận chuyển
        /// </summary>
        public string TransporterName { get; set; }

        /// <summary>
        /// Hợp đồng số (Hợp đồng vận chuyển)
        /// </summary>
        public string TransportContractCode { get; set; }

        /// <summary>
        /// Phương tiện vận chuyển
        /// </summary>
        public string Transport { get; set; }

        /// <summary>
        /// Tên (Tên người nhận hàng)
        /// </summary>
        public string StockInLegalName { get; set; }

        /// <summary>
        /// Mã số thuế (Mã số thuế người nhận hàng)
        /// </summary>
        public string StockInTaxCode { get; set; }

        /// <summary>
        /// Họ và tên người nhận hàng
        /// </summary>
        public string StockInFullName { get; set; }

        /// <summary>
        /// Địa chỉ (Địa chỉ kho nhận hàng)
        /// </summary>
        public string StockInAddress { get; set; }

        /// <summary>
        /// Mã số thuế (MST người xuất hàng)
        /// </summary>
        public string ContractCode { get; set; }

        /// <summary>
        /// Hợp đồng kinh tế ngày
        /// </summary>
        public System.DateTime? ContractDate { get; set; }
        #endregion

        #region Thông tin người mua hàng
        /// <summary>
        /// Tên người mua
        /// </summary>
        public string BuyerLegalName { get; set; }

        /// <summary>
        /// MST người mua
        /// </summary>
        public string BuyerTaxCode { get; set; }

        /// <summary>
        /// Địa chỉ người mua
        /// </summary>
        public string BuyerAddress { get; set; }

        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public string BuyerCode { get; set; }

        /// <summary>
        /// ĐT người mua
        /// </summary>
        public string BuyerPhoneNumber { get; set; }

        /// <summary>
        /// Email người mua
        /// </summary>
        public string BuyerEmail { get; set; }

        /// <summary>
        /// Tên người mua hàng
        /// </summary>
        public string BuyerFullName { get; set; }

        /// <summary>
        /// Số TK ngân hàng người mua
        /// </summary>
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// Tên ngân hàng người mua
        /// </summary>
        public string BuyerBankName { get; set; }

        /// <summary>
        /// tên người liên hệ
        /// </summary>
        public string ContactName { get; set; }
        #endregion

        #region Thông tin tổng tiền của hóa đơn
        /// <summary>
        /// Tổng tiền hàng
        /// </summary>
        public decimal? TotalSaleAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền hàng quy đổi
        /// </summary>
        public decimal? TotalSaleAmount { get; set; }

        /// <summary>
        /// tổng tiền chưa thuế
        /// </summary>
        public decimal? TotalAmountWithoutVATOC { get; set; }

        /// <summary>
        /// tổng tiền chưa thuế quy đổi
        /// </summary>
        public decimal? TotalAmountWithoutVAT { get; set; }

        /// <summary>
        /// Tỷ lệ chiết khấu cho hóa đơn chiết khấu theo giá trị hóa đơn
        /// </summary>
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// Tổng tiền CKTM
        /// </summary>
        public decimal? TotalDiscountAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền CKTM quy đổi
        /// </summary>
        public decimal? TotalDiscountAmount { get; set; }

        /// <summary>
        /// tổng tiền giảm trừ khác
        /// dành cho hóa đơn nước khi áp dụng dự thảo QD1450
        /// </summary>
        public decimal? TotalDiscountAmountDiffOC { get; set; }
        public decimal? TotalDiscountAmountDiff { get; set; }
        /// <summary>
        /// Tổng giảm trừ không chịu thuế 
        /// dành cho hóa đơn nước khi áp dụng dự thảo QD1450
        /// </summary>
        public decimal? TotalDiscountAmountKCTOC { get; set; }
        public decimal? TotalDiscountAmountKCT { get; set; }

        /// <summary>
        /// Tổng tiền thuế
        /// </summary>
        public decimal? TotalVATAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền thuế quy đổi
        /// </summary>
        public decimal? TotalVATAmount { get; set; }

        /// <summary>
        /// Tổng tiền bằng số
        /// </summary>
        public decimal? TotalAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền bằng số quy đổi
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Tổng tiền xuất kho nguyên tệ
        /// </summary>
        public decimal? StockTotalAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền xuất kho
        /// </summary>
        public decimal? StockTotalAmount { get; set; }

        /// <summary>
        /// Tổng tiền bằng chữ
        /// </summary>
        public string TotalAmountInWords { get; set; }

        /// <summary>
        /// Tổng tiền bằng chữ tiếng anh
        /// </summary>
        public string TotalAmountInWordsByENG { get; set; }

        /// <summary>
        /// Số tiền bằng chữ (VNĐ)
        /// </summary>
        public string TotalAmountInWordsVN { get; set; }

        /// <summary>
        /// Số tiền bằng chữ không dấu
        /// </summary>
        public string TotalAmountInWordsUnsignNormalVN { get; set; }
        #endregion
        /// <summary>
        /// có phải hóa đơn xăng dầu không
        /// </summary>
        public bool IsPetrol { get; set; }
        /// <summary>
        /// Có phải hóa đơn lập từ máy tính tiền không
        /// </summary>
        public bool IsInvoiceCalculatingMachine { get; set; }
        /// <summary>
        /// key đánh dấu có ký hay không ký khi phát hành hd MTT qua đầu api bất đồng bộ
        /// </summary>
        public bool IsSignInvoiceCalculatingMachine { get; set; }
        /// <summary>
        /// Có phải hóa đơn khách sạn có đơn giá chưa bao gồm thuế tiêu thụ đặc biệt không
        /// </summary>
        public bool IsHotelExciseTax { get; set; }

        /// <summary>
        /// Có phải hóa đơn khách sạn nhiều thuế suất không
        /// </summary>
        public bool IsHotelMultiVATRate { get; set; }

        /// <summary>
        /// Chi tiết hóa đơn
        /// </summary>
        /// <returns></returns>
        public System.Collections.Generic.List<InvoiceDetail> OriginalInvoiceDetail { get; set; }

        /// <summary>
        /// Danh sách các loại thuế suất
        /// </summary>
        public System.Collections.Generic.List<TaxRateInfo> TaxRateInfo { get; set; }

        /// <summary>
        /// Danh sách các loại phí
        /// </summary>
        public System.Collections.Generic.List<FeeInfo> FeeInfo { get; set; }

        /// <summary>
        /// Định dạng số để hiển thị hóa đơn
        /// </summary>
        public OptionUserDefined OptionUserDefined { get; set; }

        #region Trường mở rộng
        /// <summary>
        /// Trường mở rộng 1
        /// </summary>
        public string CustomField1 { get; set; }

        /// <summary>
        /// Trường mở rộng 2
        /// </summary>
        public string CustomField2 { get; set; }

        /// <summary>
        /// Trường mở rộng 3
        /// </summary>
        public string CustomField3 { get; set; }

        /// <summary>
        /// Trường mở rộng 4
        /// </summary>
        public string CustomField4 { get; set; }

        /// <summary>
        /// Trường mở rộng 5
        /// </summary>
        public string CustomField5 { get; set; }

        /// <summary>
        /// Trường mở rộng 6
        /// </summary>
        public string CustomField6 { get; set; }

        /// <summary>
        /// Trường mở rộng 7
        /// </summary>
        public string CustomField7 { get; set; }

        /// <summary>
        /// Trường mở rộng 8
        /// </summary>
        public string CustomField8 { get; set; }

        /// <summary>
        /// Trường mở rộng 9
        /// </summary>
        public string CustomField9 { get; set; }

        /// <summary>
        /// Trường mở rộng 10
        /// </summary>
        public string CustomField10 { get; set; }
        #endregion

        #region "Các thông tin bổ sung"
        /// <summary>
        /// Có giảm trừ thuế không
        /// </summary>
        public bool? IsTaxReduction { get; set; }

        /// <summary>
        /// Có giảm trừ thuế theo NQ43 không
        /// </summary>
        public bool? IsTaxReduction43 { get; set; }

        /// <summary>
        /// Loại giảm trừ thuế
        /// </summary>
        public int? TaxReductionType { get; set; }

        /// <summary>
        /// Mô tả loại giảm thuế
        /// </summary>
        public string TaxReductionDescription { get; set; }

        /// <summary>
        /// Mức tỷ lệ % để tính thuế giá trị gia tăng được giảm
        /// </summary>
        public int? TaxReductionVATRate { get; set; }

        /// <summary>
        /// có là hóa đơn chiết khấu ko
        /// chỉ chứa dòng HH chiết khấu hoặc HH CK và diễn giải mô tả
        /// dự thảo bổ sung QD 1450
        /// </summary>
        public bool? IsInvoiceDiscount { get; set; }

        /// <summary>
        /// có là hóa đơn theo nghị định số 15/2022/NĐ-CP
        /// căn cứ vào có là hóa đơn giảm thuế 43 không
        ///  dự thảo bổ sung QD 1450
        /// </summary>
        public bool? IsInvoiceDecree { get; set; }

        /// <summary>
        ///  Loại hiển thị hạn sử dụng mẫu CN CB-CT
        /// </summary>
        public int? ExpireDateType { get; set; }
        /// <summary>
        /// có là hóa đơn hoàn vé không 
        ///  dự thảo bổ sung QD 1450
        /// </summary>
        public bool? IsReturnTicket { get; set; }

        /// <summary>
        /// Tên chi nhánh ngân hàng người bán
        /// </summary>
        public string CompanyBranchBankName { get; set; }

        /// <summary>
        /// Tên ngân hàng (kèm chi nhánh) của người bán
        /// </summary>
        public string CompanyBankNameWithBranch { get; set; }

        /// <summary>
        /// Phí hoàn vé máy bay
        /// </summary>
        public decimal? ReturnTicketAmount { get; set; }

        /// <summary>
        /// Phí hoàn vé máy bay nguyên tệ
        /// </summary>
        public decimal? ReturnTicketAmountOC { get; set; }

        /// <summary>
        /// Phần trăm thuế tiêu thụ đặc biệt
        /// </summary>
        public decimal? ExciseTaxRate { get; set; }

        /// <summary>
        /// Tiền thuế tiêu thụ đặc biệt
        /// </summary>
        public decimal? ExciseTaxAmount { get; set; }

        /// <summary>
        /// Thuế tiêu thụ ĐB nguyên tệ
        /// </summary>
        public decimal? ExciseTaxAmountOC { get; set; }

        /// <summary>
        /// Số hợp đồng
        /// </summary>
        public string TrsContractNo { get; set; }

        /// <summary>
        /// Vận đơn
        /// </summary>
        public string TrsBLNo { get; set; }

        /// <summary>
        /// Tên tàu
        /// </summary>
        public string TrsNameVessel { get; set; }

        /// <summary>
        /// Quốc tịch
        /// </summary>
        public string TrsFlag { get; set; }

        /// <summary>
        /// Ngày đến
        /// </summary>
        public System.DateTime? TrsArrival { get; set; }

        /// <summary>
        /// Ngày đi
        /// </summary>
        public System.DateTime? TrsDeparture { get; set; }

        /// <summary>
        /// Phòng số
        /// </summary>
        public string RoomNo { get; set; }

        /// <summary>
        /// Ngày đến
        /// </summary>
        public string CheckIn { get; set; }

        /// <summary>
        /// Ngày đi
        /// </summary>
        public string CheckOut { get; set; }

        /// <summary>
        /// Chỉ số mới
        /// </summary>
        public decimal? NewIndex { get; set; }

        /// <summary>
        /// Chỉ số cũ
        /// </summary>
        public decimal? OldIndex { get; set; }

        /// <summary>
        /// Toán tử tỷ giá
        /// </summary>
        public string ExchangeRateOperation { get; set; }

        /// <summary>
        /// Ds kho
        /// </summary>
        public string ListStockName { get; set; }

        /// <summary>
        /// Ds địa chỉ kho
        /// </summary>
        public string ListStockAddress { get; set; }

        /// <summary>
        /// Mã kho đi
        /// </summary>
        public string ListFromStockCode { get; set; }

        /// <summary>
        /// Mã kho đến
        /// </summary>
        public string ListToStockCode { get; set; }

        /// <summary>
        /// Địa chỉ kho đi
        /// </summary>
        public string FromStockAddress { get; set; }

        /// <summary>
        /// Địa chỉ kho đến
        /// </summary>
        public string ToStockAddress { get; set; }

        /// <summary>
        /// Lệnh điều động số
        /// </summary>
        public string InternalCommandNo { get; set; }

        /// <summary>
        /// Lệnh điều động của
        /// </summary>
        public string InternalCommandOwner { get; set; }

        /// <summary>
        /// Lệnh điều động ngày
        /// </summary>
        public System.DateTime? InternalCommandDate { get; set; }

        /// <summary>
        /// Về việc
        /// </summary>
        public string JournalMemo { get; set; }

        /// <summary>
        /// Mức % Phí bảo vệ môi trường
        /// </summary>
        public decimal? EnvironmmentFeeRate { get; set; }

        /// <summary>
        /// Tiền phí bảo vệ môi trường
        /// </summary>
        public decimal? EnvironmmentFeeAmount { get; set; }

        /// <summary>
        /// Phí đăng kiểm
        /// </summary>
        public decimal? RegistrationFee { get; set; }

        /// <summary>
        /// Tổng chỉ số của các đồng hồ - Điện năng tiêu thụ
        /// </summary>
        public decimal? SumOfClockIndex { get; set; }

        /// <summary>
        /// Giá trị để hiển thị barcode
        /// </summary>
        public string BarCode { get; set; }

        /// <summary>
        /// Giá trị để hiển thị QRCode
        /// </summary>
        public string QRCode { get; set; }

        /// <summary>
        /// Thông tin giá đất được trừ đối với hóa đơn bất động sản
        /// </summary>
        public string ReduceLandInfor { get; set; }

        public string ListFromStockName { get; set; }

        public string ListToStockName { get; set; }

        /// <summary>
        /// Mã đơn vị
        /// </summary>
        public string OrganizationUnitCode { get; set; }

        /// <summary>
        /// Tên đơn vị
        /// </summary>
        public string OrganizationUnitName { get; set; }

        #region Thông tin giấy tờ người mua hàng
        /// <summary>
        /// Số hộ chiếu/giấy tờ nhập xuất cảnh
        /// </summary>
        public string PassportNo { get; set; }
        /// <summary>   
        /// Ngày cấp hộ chiếu/giấy tờ nhập xuất cảnh
        /// </summary>
        public DateTime? PassportDate { get; set; }
        /// <summary>
        /// Ngày hết hạn hộ chiếu/giấy tờ nhập xuất cảnh
        /// </summary>
        public DateTime? ExpirationDatePassport { get; set; }
        /// <summary>
        /// Quốc tịch
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// Teen người mua (trong danh mục)
        /// </summary>
        public string AccountObjectContactNameSIDI { get; set; }

        /// <summary>
        /// Địa chỉ giao hàng
        /// </summary>
        public string AccountObjectShippingAddressSIDI { get; set; }

        /// <summary>
        /// Fax người mua (danh mục)
        /// </summary>
        public string AccountObjectFaxSIDI { get; set; }
        /// <summary>
        /// Điện thoại liên hệ người mua (danh mục)
        /// </summary>
        public string AccountObjectContactMobileSIDI { get; set; }

        /// <summary>
        /// Điện thoại người mua (danh mục)
        /// </summary>
        public string AccountObjectTelSIDI { get; set; }

        /// <summary>
        /// Địa chỉ email người mua (danh mục)
        /// </summary>
        public string AccountObjectEmailAddressSIDI { get; set; }

        /// <summary>
        /// Số CMT/CCCD
        /// </summary>
        public string AccountObjectIdentificationNumber { get; set; }

        /// <summary>
        /// Ngày cấp CMT/CCCD
        /// </summary>
        public DateTime? AccountObjectIssueDate { get; set; }

        /// <summary>
        /// Nơi cấp
        /// </summary>
        public string AccountObjectIssueBy { get; set; }

        /// <summary>
        /// ID Khách hàng trên hóa đơn (phục vụ xuất báo cáo)
        /// </summary>
        public string AccountObjectID { get; set; }
        #endregion

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string SAEmployeeCode { get; set; }

        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string SAEmployeeName { get; set; }

        /// <summary>
        /// Điện thoại NV
        /// </summary>
        public string SAEmployeeMobile { get; set; }

        /// <summary>
        /// SĐT bàn
        /// </summary>
        public string SAEmployeeTel { get; set; }

        /// <summary>
        /// Địa chỉ giao hàng
        /// </summary>
        public string ShippingAddress { get; set; }

        /// <summary>
        /// Hạn thanh toán
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Số ngày được nợ
        /// </summary>
        public int? DueDay { get; set; }

        /// <summary>
        /// Điều khoản khác
        /// </summary>
        public string OtherTerm { get; set; }

        /// <summary>
        /// Thứ tự ghi chỉ số   
        /// </summary>
        public decimal? SortOrderIndex { get; set; }

        /// <summary>
        /// Số công tơ khách hàng
        /// </summary>
        public string CustomerMeterNumber { get; set; }

        /// <summary>
        /// Số cột đồng hồ
        /// </summary>
        public string NumberPoles { get; set; }

        /// <summary>
        /// Số sổ GCS (ghi chỉ số)
        /// </summary>
        public string NumberBook { get; set; }

        /// <summary>
        /// Số hộ gia đình
        /// </summary>
        public string HouseHoldNumber { get; set; }

        /// <summary>
        /// Kỳ thu 
        /// </summary>
        public string PeriodName { get; set; }

        /// <summary>
        ///Từ ngày 
        /// </summary>
        public DateTime? PeriodFromDate { get; set; }

        /// <summary>
        /// Đến ngày 
        /// </summary>
        public DateTime? PeriodToDate { get; set; }

        /// <summary>
        /// Truy thu  
        /// </summary>
        public decimal? WaterArrearage { get; set; }

        /// <summary>
        /// Số nước khuyến mại 
        /// </summary>
        public decimal? WaterPromotion { get; set; }

        /// <summary>
        /// Tiêu thụ  
        /// </summary>
        public decimal? WaterUsed { get; set; }

        /// <summary>
        /// điện năng tiêu thụ
        /// </summary>
        public decimal? AmountOfConsumption { get; set; }

        /// <summary>
        /// Các khoản giảm trừ hoá đơn nước
        /// </summary>
        public decimal? EnvironmmentDiscountAmount { get; set; }
        /// <summary>
        /// Mã tra cứu phòng trường hợp xuất lại
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Dòng ghi chú giảm thuế
        /// </summary>
        public string TaxReduction43Note { get; set; }

        /// <summary>
        /// Phần trăm phí phục vụ
        /// </summary>
        public decimal? ServiceFeeRate { get; set; }

        /// <summary>
        /// Token Callback để cập nhật trạng thái hóa đơn sau khi phát hành
        /// </summary>
        public string TokenCallback { get; set; }

        /// <summary>
        /// Tổng Thuế, phí khác (Mẫu HĐ vé máy bay nhiều thuế suất)
        /// </summary>
        public decimal? TotalOtherFeeOC { get; set; }

        /// <summary>
        /// Tổng Thuế, phí khác quy đổi
        /// </summary>
        public decimal? TotalOtherFee { get; set; }

        /// <summary>
        /// Phí phục vụ
        /// </summary>
        public decimal? ServiceAmount { get; set; }

        #endregion "Các thông tin bổ sung"

        #region Vé

        /// <summary>
        /// Có phải là vé hay không
        /// </summary>
        public bool? IsTicket { get; set; }

        /// <summary>
        /// Ghi chú vé
        /// </summary>
        public string TicketNote { get; set; }
        /// <summary>
        /// Người thu tiền
        /// </summary>
        public string MoneyCollecter { get; set; }
        /// <summary>
        /// Tuyến đường
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Ga đi
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Ga đến
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Số ghế
        /// </summary>
        public string Seat { get; set; }
        /// <summary>
        /// Số xe
        /// </summary>
        public string VehicleNo { get; set; }
        /// <summary>
        /// Ngày khởi hành
        /// </summary>
        public System.DateTime? DepatureDate { get; set; }

        /// <summary>
        /// Giờ khởi hành
        /// </summary>
        public string DepatureTime { get; set; }

        /// <summary>
        /// Kỳ thu
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// Tên dịch vụ
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Ngày xuất vé
        /// </summary>
        public System.DateTime? TicketIssueTime { get; set; }

        #endregion

        #region Thông tin gửi mail
        /// <summary>
        /// Gửi hóa đơn cho khách hàng sau khi phát hành
        /// </summary>
        public bool IsSendEmail { get; set; }

        /// <summary>
        /// Tên người nhận Email
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// Danh sách Email nhận (cách nhau bởi dấu ;)
        /// </summary>
        public string ReceiverEmail { get; set; }
        #endregion
        public string ToJson()
        {
            var serializer = new DataContractJsonSerializer(typeof(AccountInfo));
            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, this);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }
        public InvoiceApiResponse PostInvoicesAsync(
        string token,
        int signType,
        List<eInvoiceConnect.MISA.HDDT.InvoiceData> invoiceDataList)
        {
            var url = "https://testapi.meinvoice.vn/api/integration/invoice";
            var requestObj = new InvoiceApiRequest
            {
                SignType = signType,
                InvoiceData = invoiceDataList
            };

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";

            var json=this.ToJson();
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var serializer = new DataContractJsonSerializer(typeof(TokenResponse));
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(result)))
                {
                    return (InvoiceApiResponse)serializer.ReadObject(ms);
                }
            }
        }

    }
    public class InvoiceApiRequest
    {
        public int SignType { get; set; }
        public List<eInvoiceConnect.MISA.HDDT.InvoiceData> InvoiceData { get; set; }
    }
    public class InvoiceApiResponse
    {
        public bool success { get; set; }
        public string errorCode { get; set; }
        public string descriptionErrorCode { get; set; }
        public object createInvoiceResult { get; set; }
        public object publishInvoiceResult { get; set; }
    }
}
