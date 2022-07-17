using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_rate_parser.Interfaces
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
