using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eInvoiceConnect.MISA.HDDT
{
    /// <summary>
    /// Thông tin định dạng số, đồng tiền hạch toán
    /// </summary>
    public class OptionUserDefined
    {
        /// <summary>
        /// Đồng tiền hạch toán
        /// </summary>
        /// <returns></returns>
        public string MainCurrency { get; set; }

        /// <summary>
        /// Định dạng số tiền quy dổi
        /// </summary>
        /// <returns></returns>
        public string AmountDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng số tiền nguyên tệ
        /// </summary>
        /// <returns></returns>
        public string AmountOCDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng đơn giá nguyên tệ
        /// </summary>
        /// <returns></returns>
        public string UnitPriceOCDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng đơn giá quy đổi
        /// </summary>
        /// <returns></returns>
        public string UnitPriceDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng số lượng
        /// </summary>
        /// <returns></returns>
        public string QuantityDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng tỷ lệ
        /// </summary>
        /// <returns></returns>
        public string CoefficientDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng tỷ giá
        /// </summary>
        /// <returns></returns>
        public string ExchangRateDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng tham số decimal trong ClockInfo
        /// </summary>
        /// <returns></returns>
        public string ClockDecimalDigits { get; set; }

    }
}
