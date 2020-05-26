
using PreciousDotNet.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PreciousDotNet.Api.GoldPrice.Service
{
    class GoldPriceService : IGoldPriceService
    {
        public IEnumerable<string> GetCurrencies()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<string>> GetCurrenciesAsync()
        {
            throw new System.NotImplementedException();
        }

        public HttpResponseDto GetGoldPrice(string currency = "EUR")
        {
            throw new System.NotImplementedException();
        }

        public HttpResponseDto GetGoldPrice(IEnumerable<string> currencies)
        {
            throw new System.NotImplementedException();
        }

        public Task<HttpResponseDto> GetGoldPriceAsync(string currency = "EUR")
        {
            throw new System.NotImplementedException();
        }

        public Task<HttpResponseDto> GetGoldPriceAsync(IEnumerable<string> currencies)
        {
            throw new System.NotImplementedException();
        }
    }
}
