using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eInvoiceConnect.MISA.HDDT
{
    public class Operation
    {
        string baseUrl { get; set; }
        string TokenUrl() { return baseUrl + "/auth/token"; }
        string ToaHoaDonUrl() { return baseUrl + "/invoice/create"; }   


        TokenResponse Token { get; set; }
        public void GetToken()
        {
            AccountInfo accountInfo = new AccountInfo();
            Token=accountInfo.GetToken(TokenUrl());
        }
        public void TaoHoaDon()
        {
            GetToken();
            
            if (Token != null)
            {
                
            }
            
        }
        public void KyHoaDon()
        {
            GetToken();
            if (Token != null)
            {
                // Implement signing logic here
            }
        }


    }
}
