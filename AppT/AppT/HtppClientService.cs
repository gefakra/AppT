using AppT;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

using Xamarin.Forms;

namespace AppT
{    
    public class HtppClientService : IHttpClientService
    {
        private readonly HttpClient _client = new HttpClient();
        private readonly string _url = "https://yastatic.net/market-export/_/partner/help/YML.xml";
            

        private async Task<string> LoadXmlAsync()
        {
            var responseBytes = await _client.GetByteArrayAsync(_url);
            return Encoding.GetEncoding(1251).GetString(responseBytes);
        }
        public async Task<List<int>> LoadOffersIdAsync()
        {
            using var stringReader = new StringReader(await LoadXmlAsync());
            var xmlSerializer = new XmlSerializer(typeof(YmlCatalog));
            var result = (YmlCatalog)xmlSerializer.Deserialize(stringReader);
            return result.Shop.Offers.OfferList?.Select(i=>i.Id).ToList() ?? new List<int>();
        }

        public async Task<Offer> LoadfferByIdAsync(int offer_Id)
        {
            using var stringReader = new StringReader(await LoadXmlAsync());
            var xmlSerializer = new XmlSerializer(typeof(YmlCatalog));
            var catalog = (YmlCatalog)xmlSerializer.Deserialize(stringReader);
            return catalog.Shop?.Offers?.OfferList?.FirstOrDefault(o=>o.Id == offer_Id);
        }
    }
}
