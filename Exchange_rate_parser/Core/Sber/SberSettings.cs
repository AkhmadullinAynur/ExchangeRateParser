using Exchange_rate_parser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_rate_parser.Core.Sber
{
    class SberSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://www.sberbank.ru/ru/quotes/currencies";
    }
}
