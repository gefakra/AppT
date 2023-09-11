using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppT
{
    public interface IHttpClientService
    {
        public Task<List<int>> LoadOffersIdAsync();
        public Task<Offer> LoadfferByIdAsync(int id);
    }
}
