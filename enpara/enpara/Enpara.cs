using System;
using System.Threading;
using HtmlAgilityPack;

namespace enpara
{
    class Enpara
    {
        private string _enparaDollarBuy = "";
        private string _enparaDollarSell = "";
        private string _enparaGoldBuy = "";
        private string _enparaGoldSell = "";

        private string n_enparaDollarBuy = "";
        private string n_enparaDollarSell = "";
        private string n_enparaGoldBuy= "";
        private string n_enparaGoldSell = "";

        private string _dollarBuyChangeSign = "";
        private string _dollarSellChangeSign = "";
        private string _goldBuyChangeSign = "";
        private string _goldSellChangeSign = "";

        private string _dollarDiff = "";
        private string _goldDiff = "";

        private const string _increaseSign = "\u25b2";
        private const string _decreaseSign = "\u25bc";
        private const string _noChangeSign = "\u25ac";

        private const string URL = "https://www.qnbfinansbank.enpara.com/doviz-kur-bilgileri/doviz-altin-kurlari.aspx";

        public string EnparaDollarBuy { get => _enparaDollarBuy;  }
        public string EnparaDollarSell { get => _enparaDollarSell; }
        public string EnparaGoldBuy { get => _enparaGoldBuy;  }
        public string EnparaGoldSell { get => _enparaGoldSell; }
        public string DollarBuyChangeSign { get => _dollarBuyChangeSign; }
        public string DollarSellChangeSign { get => _dollarSellChangeSign;  }
        public string GoldBuyChangeSign { get => _goldBuyChangeSign;  }
        public string GoldSellChangeSign { get => _goldSellChangeSign;  }
        public string DollarDiff { get => _dollarDiff;  }
        public string GoldDiff { get => _goldDiff; }

        HtmlWeb web = null;
        HtmlDocument doc = null;

        public Enpara()
        {
            web = new HtmlWeb();
            web.PreRequest = delegate (System.Net.HttpWebRequest webRequest)
            {
                webRequest.Timeout = Int32.Parse(Properties.Settings.Default.requestTimeout);
                return true;
            };
        }

        private HtmlDocument loadFromWeb(string URL)
        {
            if (Properties.Settings.Default.isProxyEnabledFlag)
            {
                doc = web.Load(URL, Properties.Settings.Default.proxyAddress, Int32.Parse(Properties.Settings.Default.proxyPort), Properties.Settings.Default.proxyUser, Properties.Settings.Default.proxyPassword);
            }
            else
            {
                doc = web.Load(URL);
            }

            return doc;
        }

        private void parse()
        {
            try
            {
                HtmlDocument doc = loadFromWeb(URL);

                n_enparaDollarBuy = doc.DocumentNode.SelectNodes("//*[@id=\"pnlContent\"]/span[1]/dl/dd[1]/div/span")[0].InnerText;
                n_enparaDollarSell = doc.DocumentNode.SelectNodes("//*[@id=\"pnlContent\"]/span[1]/dl/dd[2]/div/span")[0].InnerText;
                n_enparaGoldBuy = doc.DocumentNode.SelectNodes("//*[@id=\"pnlContent\"]/span[3]/dl/dd[1]/div/span")[0].InnerText;
                n_enparaGoldSell = doc.DocumentNode.SelectNodes("//*[@id=\"pnlContent\"]/span[3]/dl/dd[2]/div/span")[0].InnerText;

            }
            catch (Exception e)
            {
                n_enparaDollarBuy = "0 TL ";
                n_enparaDollarSell = "0 TL ";
                n_enparaGoldBuy = "0 TL ";
                n_enparaGoldSell = "0 TL ";
            }
            
        }

        public void loadResult()
        {
            parse();

            determineSign(ref _enparaDollarBuy, ref n_enparaDollarBuy, ref _dollarBuyChangeSign);
            determineSign(ref _enparaDollarSell, ref n_enparaDollarSell, ref _dollarSellChangeSign);
            determineSign(ref _enparaGoldBuy, ref n_enparaGoldBuy, ref _goldBuyChangeSign);
            determineSign(ref _enparaGoldSell, ref n_enparaGoldSell, ref _goldSellChangeSign);

            _dollarDiff = ((parseValue(n_enparaDollarSell) - parseValue(n_enparaDollarBuy)) * 100).ToString("0.00") + " Kuruş";
            _goldDiff = (parseValue(n_enparaGoldSell) - parseValue(n_enparaGoldBuy)).ToString("0.00") + " TL";
        }

        private float parseValue(string text)
        {
            if (!Equals("", text))
            {
                string numContent = text.Substring(0, text.Length - 4);
                if (!Equals("", numContent))
                {
                    return float.Parse(numContent);
                }

            }
            return 0F;

        }

        private bool determineSign(ref string _currentVal, ref string _newVal, ref string _signVariable)
        {
            bool _result = false;
            _signVariable = _noChangeSign;
            if (!Equals(_newVal, _currentVal))
            {
                if (parseValue(_newVal) > parseValue(_currentVal))
                {
                    _signVariable = _increaseSign;
                }
                if (parseValue(_newVal) < parseValue(_currentVal))
                {
                    _signVariable = _decreaseSign;
                }
                _currentVal = _newVal;
                _result = true;
            }

            return _result;
        }
    }
}
