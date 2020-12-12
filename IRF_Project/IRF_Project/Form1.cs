﻿using IRF_Project.Entities;
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


        public Form1()
        {
            InitializeComponent();

            WebServiceCall();
        }

        public void WebServiceCall()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request1 = new GetExchangeRatesRequestBody()
            {
                currencyNames="EUR",
                startDate="2020-01-01",
                endDate="2020-06-30"
            };

            var request2 = new GetExchangeRatesRequestBody()
            {
                currencyNames = "USD",
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

        
    }
}
