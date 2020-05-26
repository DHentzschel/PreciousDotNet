using PreciousDotNet.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PreciousDotNet.Api.GoldPrice.Service
{
    interface IGoldPriceService
    {
        Task<HttpResponseDto> GetGoldPriceAsync(string currency);

        Task<HttpResponseDto> GetGoldPriceAsync(IEnumerable<string> currencies);

        Task<IEnumerable<string>> GetCurrenciesAsync();

        HttpResponseDto GetGoldPrice(string currency);

        HttpResponseDto GetGoldPrice(IEnumerable<string> currencies);

        IEnumerable<string> GetCurrencies();
    }
}
