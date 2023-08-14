using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppT
{    
    public class HttpConext
    {
        private static HttpClient Client = new HttpClient();
        private readonly string _url;
        public HttpConext() 
        {
            _url = "https://yastatic.net/market-export/_/partner/help/YML.xml";            
        }        
        public async Task<yml_catalog> GetContent()
        {
            Encoding encoding = Encoding.GetEncoding(1251);
            var xmlSerializer = new XmlSerializer(typeof(yml_catalog));
            var responce = await Client.GetByteArrayAsync(_url);
            var responseConvert = Encoding.Convert(encoding, Encoding.UTF8, responce);
            var stringRead = new StringReader(Encoding.UTF8.GetString(responseConvert));
            return (yml_catalog)xmlSerializer.Deserialize(stringRead);           
        }
    }
}
