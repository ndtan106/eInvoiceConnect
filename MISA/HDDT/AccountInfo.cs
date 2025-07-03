using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace eInvoiceConnect.MISA.HDDT
{
    public class AccountInfo
    {
        public string appid { get; set; }
        public string taxcode { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string ToJson()
        {
            var serializer = new DataContractJsonSerializer(typeof(AccountInfo));
            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, this);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }
        public TokenResponse GetToken(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";

            var json = this.ToJson();
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
                    return (TokenResponse)serializer.ReadObject(ms);
                }
            }



        }
    }
    public class TokenResponse
    {
        public bool Success { get; set; }
        public string Data { get; set; }
        public string ErrorCode { get; set; }
        public string Errors { get; set; }
        public string CustomData { get; set; }
    }
}
