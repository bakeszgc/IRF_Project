using IRF_Project.Entities;
using IRF_Project.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        List<RateData> Rates1 = new List<RateData>();
        List<RateData> Rates2 = new List<RateData>();

        List<string> CurrenciesInput = new List<string>();
        List<string> CurrenciesOutput = new List<string>();

        string curr1, curr2;

        public Form1()
        {
            InitializeComponent();

            WebServiceCall();
            GetCurr();
            currList1.DataSource = CurrenciesInput;
            currList2.DataSource = CurrenciesOutput;
        }

        private void WebServiceCall()
        {
            
            if (currList1.SelectedItem==null) curr1 = "EUR";
            if (currList2.SelectedItem == null) curr2 = "USD";
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request1 = new GetExchangeRatesRequestBody()
            {
                currencyNames= curr1,
                startDate="2020-01-01",
                endDate="2020-06-30"
            };

            var request2 = new GetExchangeRatesRequestBody()
            {
                currencyNames = curr2,
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response1 = mnbService.GetExchangeRates(request1);
            var response2 = mnbService.GetExchangeRates(request2);

            var result1 = response1.GetExchangeRatesResult;
            var result2 = response2.GetExchangeRatesResult;

            var xml1 = new XmlDocument();
            var xml2 = new XmlDocument();

            xml1.LoadXml(result1);
            xml2.LoadXml(result2);

            foreach (XmlElement element1 in xml1.DocumentElement)
            {
                var rate = new RateData();
                Rates1.Add(rate);

                rate.Date = DateTime.Parse(element1.GetAttribute("date"));

                var childElement = (XmlElement)element1.ChildNodes[0];
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit!=1) rate.Value = value / unit;
            }

            foreach (XmlElement element2 in xml2.DocumentElement)
            {
                var rate = new RateData();
                Rates2.Add(rate);

                rate.Date = DateTime.Parse(element2.GetAttribute("date"));

                var childElement = (XmlElement)element2.ChildNodes[0];
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0) rate.Value = value / unit;
            }
        }

        public void GetCurr()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var currRequest = new GetCurrenciesRequestBody() { };
            var currResponse = mnbService.GetCurrencies(currRequest);
            var currResult = currResponse.GetCurrenciesResult;
            
            var currXml = new XmlDocument();
            currXml.LoadXml(currResult);

            foreach (XmlElement element in currXml.DocumentElement)
            {
                
                for (int i = 0; i < element.InnerText.Length/3; i++)
                {
                    string currency;
                    var currChildElement = (XmlElement)element.ChildNodes[i];
                    currency = currChildElement.InnerText.ToString();
                    CurrenciesInput.Add(currency);
                    CurrenciesOutput.Add(currency);
                }  
            }

        }

        private void Atvalt()
        {

        }

        private void currSearch1_TextChanged(object sender, EventArgs e)
        {
            currList1.DataSource = (from x in CurrenciesInput
                                    where x.Contains(currSearch1.Text)
                                    select x).ToList();
        }

        private void currInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
