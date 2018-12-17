using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace Parser.Core.Url
{
    class UrlParser : IParser<String>
    {
        public String Parse(IHtmlDocument document)
        {
            string result;
            result = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("p-price")).ToString();
            return result;
        }
    }
}
