using IRF_Project.Entities;
using IRF_Project.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string inputString, outputString;

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
                //startDate = DateTime.Today.AddYears(-1).ToString(),
                //endDate = DateTime.Today.ToString()
                startDate = dateTimePicker1.Value.AddYears(-1).ToString(),
                endDate = dateTimePicker1.Value.ToString()
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
                //startDate = DateTime.Today.AddYears(-1).ToString(),
                //endDate = DateTime.Today.ToString()
                startDate = dateTimePicker1.Value.AddYears(-1).ToString(),
                endDate = dateTimePicker1.Value.ToString()
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
            else currOutput.Text = Math.Round((decimal.Parse(currInput.Text) * arfolyam / arfolyamOutput), 4).ToString().TrimEnd(new char[] { '0' });
        }

        private void AtvaltasReverse()
        {
            if (selectedCurrency == "HUF") arfolyam = 1;
            else arfolyam = Rates[0].Value;

            if (selectedCurrencyOutput == "HUF") arfolyamOutput = 1;
            else arfolyamOutput = RatesOutput[0].Value;

            if (currOutput.Text == "") currInput.Text = "0";
            else currInput.Text = Math.Round((decimal.Parse(currOutput.Text) * arfolyamOutput / arfolyam),4).ToString().TrimEnd(new char[] { '0' });
        }

        private void AtvaltasComplex()
        {
            if (currInput.Enabled == true) Atvaltas();
            else AtvaltasReverse();
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
                AtvaltasComplex();
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
                AtvaltasComplex();
            }
        }

        private void SaveToCsv(int i, StreamWriter sw)
        {
            decimal saveArfolyamInput, saveArfolyamOutput;
            string saveCurrInput, saveCurrOutput;

            if (selectedCurrency == "HUF")
            {
                saveArfolyamInput = 1;
                saveCurrInput = "HUF";
            }
            else
            {
                saveArfolyamInput = Rates[i].Value;
                saveCurrInput = Rates[i].Currency;
            }

            if (selectedCurrencyOutput == "HUF")
            {
                saveArfolyamOutput = 1;
                saveCurrOutput = "HUF";
            }
            else
            {
                saveArfolyamOutput = RatesOutput[i].Value;
                saveCurrOutput = RatesOutput[i].Currency;
            }

            sw.Write(Rates[i].Date.ToString("yyy-MM-dd"));
            sw.Write(';');
            if (currInput.Enabled == true)
            {
                sw.Write(saveCurrInput);
                sw.Write('-');
                sw.Write(saveCurrOutput);
                sw.Write(';');
                sw.Write(saveArfolyamInput / saveArfolyamOutput);
            }
            else
            {
                sw.Write(saveCurrOutput);
                sw.Write('-');
                sw.Write(saveCurrInput);
                sw.Write(';');
                sw.Write(saveArfolyamOutput / saveArfolyamInput);
            }
            sw.WriteLine();
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
            lblInput.Text = selectedCurrency;
        }

        private void currList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCurrencyOutput = currList2.SelectedItem.ToString();
            AllProcessOutput();
            lblOutput.Text = selectedCurrencyOutput;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (currOutput.Enabled==false)
            {
                currInput.Enabled = false;
                currOutput.Enabled = true;
            }
            else
            {
                currInput.Enabled = true;
                currOutput.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AllProcess();
            AllProcessOutput();
        }

        private void btnSavePastWeek_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Separated Values (*.csv) | *.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName,false,Encoding.UTF8))
            {
                for (int i = 0; Rates[i].Date >= Rates[0].Date.AddDays(-7); i++)
                {
                    SaveToCsv(i, sw);
                }
            }
        }

        private void btnSavePastMonth_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Separated Values (*.csv) | *.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                for (int i = 0; Rates[i].Date >= Rates[0].Date.AddMonths(-1); i++)
                {
                    SaveToCsv(i, sw);
                }
            }
        }

        private void btnSavePastYear_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Separated Values (*.csv) | *.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                for (int i = 0; i < Rates.Count(); i++)
                {
                    SaveToCsv(i, sw);
                }
            }
        }

        private void currOutput_TextChanged(object sender, EventArgs e)
        {
            Regex numRegex = new Regex("^[0-9]*[,]?[0-9]*$");

            if (numRegex.IsMatch(currOutput.Text))
            {
                AtvaltasComplex();
                outputString = currOutput.Text;
            }
            else
            {
                currOutput.Text = outputString;
                MessageBox.Show("Ebbe a mezőbe csak számokat és legfeljebb egy tizedesvesszőt írhatsz!", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void currInput_TextChanged(object sender, EventArgs e)
        {
            Regex numRegex = new Regex("^[0-9]*[,]?[0-9]*$");

            if (numRegex.IsMatch(currInput.Text))
            {
                AtvaltasComplex();
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
