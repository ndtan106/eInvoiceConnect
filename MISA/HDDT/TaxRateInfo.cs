﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eInvoiceConnect.MISA.HDDT
{
    /// <summary>
    /// Thông tin các loại thuế suất
    /// </summary>
    public class TaxRateInfo
    {
        /// <summary>
        /// Tên loại thuế suất
        /// </summary>
        public string VATRateName { get; set; }

        /// <summary>
        /// Tiền chưa thuế
        /// </summary>
        public decimal? AmountWithoutVATOC { get; set; }

        /// <summary>
        /// Tiền thuế
        /// </summary>
        public decimal? VATAmountOC { get; set; }
    }

}
