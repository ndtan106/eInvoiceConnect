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


    }
}
