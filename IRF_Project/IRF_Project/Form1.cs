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

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebServiceCall();
        }

        private void WebServiceCall()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request1 = new GetExchangeRatesRequestBody()
            {
                currencyNames="EUR",
                startDate="2020-01-01",
                endDate="2020-06-30"
            };

            var response1 = mnbService.GetExchangeRates(request1);

            var result1 = response1.GetExchangeRatesResult;
        }
    }
}
