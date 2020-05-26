using System.Collections.Generic;

namespace PreciousDotNet.Dto
{
    public class HttpResponseDto
    {
        public ulong Ts { get; set; }

        public ulong Tsj { get; set; }

        public List<CurrencyDto> Items { get; set; }
    }
}
