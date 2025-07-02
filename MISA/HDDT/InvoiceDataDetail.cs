using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eInvoiceConnect.MISA.HDDT
{
    /// <summary>
    /// thông tin dữ liệu hàng hóa dịch vụ
    /// </summary>
    public class InvoiceDetail
    {
        /// <summary>
        /// Tính chất (1: HHDV; 2: khuyến mại; 3: chiết khẩu; 4: ghi chú/diễn giải)
        /// </summary>
        public int ItemType { get; set; }

        /// <summary>
        /// STT dòng mặt hàng (bắt đầu từ 1)
        /// </summary>
        public int LineNumber { get; set; }
        /// <summary>
        /// ID mặt hàng
        /// </summary>
        public string ItemID { get; set; }
        /// <summary>
        /// Mã mặt hàng
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// Tên mặt hàng
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Đơn vị tính
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// Số lượng mặt hàng
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Đơn giá
        /// </summary>
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Tỷ lệ chiết khấu
        /// </summary>
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// Tiền chiết khấu
        /// </summary>
        public decimal? DiscountAmountOC { get; set; }

        /// <summary>
        /// Tiền chiết khấu quy đổi
        /// </summary>
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// Thành tiền
        /// </summary>
        public decimal? AmountOC { get; set; }

        /// <summary>
        /// Thành tiền quy đổi
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Thành tiền chưa thuế
        /// </summary>
        public decimal? AmountWithoutVATOC { get; set; }

        /// <summary>
        /// Đơn giá sau thuế
        /// </summary>
        public decimal? UnitPriceAfterTax { get; set; }

        /// <summary>
        /// Thành tiền sau thuế quy đổi
        /// </summary>
        public decimal? AmountAfterTax { get; set; }

        /// <summary>
        /// Tên loại thuế suất
        /// </summary>
        public string VATRateName { get; set; }

        /// <summary>
        /// Tiền thuế
        /// </summary>
        public decimal? VATAmountOC { get; set; }
        /// <summary>
        /// trường thông tin tiền thuế cho ND 1450
        /// </summary>
        public decimal? VATAmountOCND1450 { get; set; }

        /// <summary>
        /// Tiền thuế quy đổi
        /// </summary>
        public decimal? VATAmount { get; set; }

        /// <summary>
        /// Trường mở rộng 1
        /// </summary>
        public string CustomField1Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 2
        /// </summary>
        public string CustomField2Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 3
        /// </summary>
        public string CustomField3Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 4
        /// </summary>
        public string CustomField4Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 5
        /// </summary>
        public string CustomField5Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 6
        /// </summary>
        public string CustomField6Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 7
        /// </summary>
        public string CustomField7Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 8
        /// </summary>
        public string CustomField8Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 9
        /// </summary>
        public string CustomField9Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 10
        /// </summary>
        public string CustomField10Detail { get; set; }

        /// <summary>
        /// Thứ tự hiển thị lên mẫu
        /// </summary>
        public int? SortOrder { get; set; }

        /// <summary>
        /// Diễn giải hàng hóa
        /// </summary>
        public string InventoryItemNote { get; set; }

        /// <summary>
        /// Số lô
        /// </summary>
        public string LotNo { get; set; }

        /// <summary>
        /// Hạn sử dụng
        /// </summary>
        public System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Mã ĐVT
        /// </summary>
        public string UnitCode { get; set; }

        /// <summary>
        /// Tiền thuế đc giảm nguyên tệ (406)
        /// </summary>
        public decimal? TaxReductionAmountOC { get; set; }

        /// <summary>
        /// Tiền thuế được giảm quy đổi (406)
        /// </summary>
        public decimal? TaxReductionAmount { get; set; }

        /// <summary>
        /// Tiền thuế đc giảm nguyên tệ (43)
        /// </summary>
        public decimal? TaxReduction43AmountOC { get; set; }

        /// <summary>
        /// Tiền thuế được giảm quy đổi (43)
        /// </summary>
        public decimal? TaxReduction43Amount { get; set; }

        /// <summary>
        /// % giảm thuế (43)
        /// </summary>
        public decimal? TaxReduction43Rate { get; set; }

        /// <summary>
        /// Nhóm ngành nghề tính thuế GTGT theo tỷ lệ % trên doanh thu 
        /// 0. Hàng hóa dịch vụ không chịu thuế GTGT hoặc hàng hóa dịch vụ áp dụng thuế suất 0%; 
        /// 1. Phân phối, cung cấp hàng hóa áp dụng thuế suất 1%; 
        /// 5. Dịch vụ, xây dựng không bao thầu nguyên vật liệu áp dụng thuế suất 5%; 
        /// 3. Sản xuất, vận tải, dịch vụ có gắn với hàng hóa, xây dựng có bao thầu nguyên vật liệu áp dụng thuế suất 3%; 
        /// 2. Hoạt động kinh doanh khác áp dụng thuế suất 2%
        /// </summary>
        public int? VATRateBusinessGroup { get; set; }

        ///// <summary>
        ///// Số lượng thực nhập
        ///// </summary>
        public decimal? InWards { get; set; }

        /// <summary>
        /// Số khung
        /// </summary>
        public string ChassisNumber { get; set; }

        /// <summary>
        /// Số khung
        /// </summary>
        public string EngineNumber { get; set; }

        /// <summary>
        /// Xuất bản phí
        /// </summary>
        public string PublishFee { get; set; }

        public bool? IsTaxReduction43Detail { get; set; }

        /// <summary>
        /// Tiền phí tiêu thụ đặc biệt
        /// </summary>
        public decimal? ExciseTaxAmount { get; set; }
        /// <summary>
        /// Tiền phí tiêu thụ đặc biệt (nguyên tệ)
        /// </summary>
        public decimal? ExciseTaxAmountOC { get; set; }
        /// <summary>
        /// thuế suất tiêu thụ đặc biệt
        /// </summary>
        public decimal? ExciseTaxRate { get; set; }
        /// <summary>
        /// Đơn vị giá sau thuế tiêu thụ đặc biệt
        /// </summary>
        public decimal UnitPriceAfterExciseVAT { get; set; }
        /// <summary>
        /// tổng tiền sau thuế tiêu thụ đặc biệt nguyên tệ
        /// </summary>
        public decimal AmountAfterExciseTaxOC { get; set; }
        /// <summary>
        /// tổng tiền sau thuế tiêu thụ đặc biệt (quy đổi)
        /// </summary>
        public decimal AmountAfterExciseTax { get; set; }
        /// <summary>
        /// là hàng hóa chịu thuế tiêu thụ đb
        /// </summary>
        public bool? IsSubjectToExciseTax { get; set; }
        /// <summary>
        /// Mã quy cách
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// MQC 1
        /// </summary>
        public string SerialNumber1 { get; set; }

        /// <summary>
        /// MQC 2
        /// </summary>
        public string SerialNumber2 { get; set; }

        /// <summary>
        /// MQC 3
        /// </summary>
        public string SerialNumber3 { get; set; }

        /// <summary>
        /// MQC 4
        /// </summary>
        public string SerialNumber4 { get; set; }

        /// <summary>
        /// MQC 5
        /// </summary>
        public string SerialNumber5 { get; set; }

        /// <summary>
        /// MQC tổng hợp
        /// </summary>
        public string SerialNumberMerge { get; set; }
        /// <summary>
        /// Tiền công
        /// </summary>
        public decimal? WageAmountOC { get; set; }
        /// <summary>
        /// Tiền công QĐ
        /// </summary>
        public decimal? WageAmount { get; set; }
        /// <summary>
        /// Đơn giá ngày công
        /// </summary>
        public decimal? WagePriceAmount { get; set; }
        /// <summary>
        /// Chiết khấu tiền công QĐ
        /// </summary>
        public decimal? WagePriceDiscountAmount { get; set; }
        /// <summary>
        /// Chiết khấu tiền công nguyên tệ
        /// </summary>
        public decimal? WageDiscountAmountOC { get; set; }
        /// <summary>
        /// Phí phục vụ
        /// </summary>
        public decimal? ServiceAmount { get; set; }
        /// <summary>
        /// % phí phục vụ (Áp dụng cho mẫu MTT Khách sạn nhiều thuế suất)
        /// </summary>
        public decimal? ServiceFeeRate { get; set; }
    }


}
