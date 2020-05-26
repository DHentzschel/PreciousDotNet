using PreciousDotNet.Api.GoldPrice.Service;
using PreciousDotNet.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PreciousDotNet.Api
{
    public class GoldPriceRepository : IGoldPriceRepository
    {
        private readonly IGoldPriceService _goldPriceService = new GoldPriceService();

        public Task<HttpResponseDto> GetGoldPriceAsync(string currency = "EUR") => _goldPriceService.GetGoldPriceAsync(currency);

        public Task<HttpResponseDto> GetGoldPriceAsync(IEnumerable<string> currencies) => _goldPriceService.GetGoldPriceAsync(currencies);

        public Task<IEnumerable<string>> GetCurrenciesAsync() => _goldPriceService.GetCurrenciesAsync();

        public HttpResponseDto GetGoldPrice(string currency = "EUR") => _goldPriceService.GetGoldPrice(currency);

        public HttpResponseDto GetGoldPrice(IEnumerable<string> currencies) => _goldPriceService.GetGoldPrice(currencies);

        public IEnumerable<string> GetCurrencies() => _goldPriceService.GetCurrencies();
    }
}
