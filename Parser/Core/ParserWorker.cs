using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        HtmlLoader loader;

        bool isActive;

        #region Properties

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        #endregion

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            //for(int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await loader.GetSourceByPageId(1);
                var domParser = new HtmlParser();

                var document = await domParser.ParseAsync(https://tmall.aliexpress.com/item/Xiaomi-Redmi-6A-16/32904618453.html?spm=a2g0v.search0104.3.2.5dcbb7dbY3BOWd&ws_ab_test=searchweb0_0%2Csearchweb201602_3_10065_10068_319_317_10696_453_10084_454_10083_10618_10307_10301_538_537_536_10059_10884_10889_10887_100031_321_322_10915_10103_10914_10911_10910%2Csearchweb201603_51%2CppcSwitch_0&algo_pvid=023758b1-a484-42a3-bfe6-755f62ca768b&algo_expid=023758b1-a484-42a3-bfe6-755f62ca768b-0);

                var result = parser.Parse(document);

                OnNewData?.Invoke(this, result);
            }

            OnCompleted?.Invoke(this);
            isActive = false;
        }


    }
}
