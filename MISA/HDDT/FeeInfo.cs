using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eInvoiceConnect.MISA.HDDT
{
    /// <summary>
    /// Thông tin các loại phí
    /// </summary>
    public class FeeInfo
    {
        /// <summary>
        /// Tên loại phí
        /// </summary>
        public string FeeName { get; set; }

        /// <summary>
        /// Tiền phí
        /// </summary>
        public decimal? FeeAmountOC { get; set; }
    }

}
