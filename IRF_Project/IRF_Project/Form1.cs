using IRF_Project.Entities;
using IRF_Project.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        List<RateData> Rates = new List<RateData>();
        List<RateData> RatesOutput = new List<RateData>();

        List<string> CurrenciesInput = new List<string>();
        List<string> CurrenciesOutput = new List<string>();

        private string result, resultOutput;
        private string selectedCurrency, selectedCurrencyOutput;
        private bool IsFormLoaded = false;
        private decimal arfolyam, arfolyamOutput;
        private string inputString;

        public Form1()
        {
            InitializeComponent();

            
            GetCurr();
            currList1.DataSource = CurrenciesInput;
            currList2.DataSource = CurrenciesOutput;
        }        

        private void GetCurr()
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

        private void WebServiceCall()
        {
            Rates.Clear();

            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = selectedCurrency,
                startDate = DateTime.Today.AddYears(-1).ToString(),
                endDate = DateTime.Today.ToString()
            };
            var response = mnbService.GetExchangeRates(request);
            result = response.GetExchangeRatesResult;
        }

        private void WebServiceCallOutput()
        {
            RatesOutput.Clear();

            var mnbServiceOutput = new MNBArfolyamServiceSoapClient();
            var requestOutput = new GetExchangeRatesRequestBody()
            {
                currencyNames = selectedCurrencyOutput,
                startDate = DateTime.Today.AddYears(-1).ToString(),
                endDate = DateTime.Today.ToString()
            };
            var responseOutput = mnbServiceOutput.GetExchangeRates(requestOutput);
            resultOutput = responseOutput.GetExchangeRatesResult;
        }

        private void ProcessXml()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                RateData r = new RateData();
                Rates.Add(r);

                r.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                r.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0) r.Value = value / unit;
            }
        }

        private void ProcessXmlOutput()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(resultOutput);

            foreach (XmlElement element in xml.DocumentElement)
            {
                RateData r = new RateData();
                RatesOutput.Add(r);

                r.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                r.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0) r.Value = value / unit;
            }
        }

        private void Atvaltas()
        {
            if (selectedCurrency == "HUF") arfolyam = 1;
            else arfolyam = Rates[0].Value;

            if (selectedCurrencyOutput == "HUF") arfolyamOutput = 1;
            else arfolyamOutput = RatesOutput[0].Value;

            if (currInput.Text == "") currOutput.Text = "0";
            else currOutput.Text = (decimal.Parse(currInput.Text) * arfolyam / arfolyamOutput).ToString();
        }

        private void AllProcess()
        {
            if (IsFormLoaded == true)
            {
                if (selectedCurrency != "HUF")
                {
                    WebServiceCall();
                    ProcessXml();
                }
                Atvaltas();
            }
        }

        private void AllProcessOutput()
        {
            if (IsFormLoaded==true)
            {
                if (selectedCurrencyOutput != "HUF")
                {
                    WebServiceCallOutput();
                    ProcessXmlOutput();
                }
                Atvaltas();
            }
        }

        private void currSearch1_TextChanged(object sender, EventArgs e)
        {
            currList1.DataSource = (from x in CurrenciesInput
                                    where x.Contains(currSearch1.Text.ToUpper())
                                    select x).ToList();
        }

        private void currList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCurrency = currList1.SelectedItem.ToString();
            AllProcess();
        }

        private void currList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCurrencyOutput = currList2.SelectedItem.ToString();
            AllProcessOutput();
        }

        private void currInput_TextChanged(object sender, EventArgs e)
        {
            Regex numRegex = new Regex("^[0-9]*[,]?[0-9]*$");

            if (numRegex.IsMatch(currInput.Text))
            {
                Atvaltas();
                inputString = currInput.Text;
            }
            else
            {
                currInput.Text = inputString;
                MessageBox.Show("Ebbe a mezőbe csak számokat és legfeljebb egy tizedesvesszőt írhatsz!","Figyelem",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllProcess();
            AllProcessOutput();
            IsFormLoaded = true;
        }

        private void currSearch2_TextChanged(object sender, EventArgs e)
        {
            currList2.DataSource = (from x in CurrenciesOutput
                                    where x.Contains(currSearch2.Text.ToUpper())
                                    select x).ToList();
        }
    }
}
