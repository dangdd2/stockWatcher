﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common;
using Newtonsoft.Json;
using SendGrid;
using SendGrid.Helpers.Mail;
using JsonSerializer = RestSharp.Serialization.Json.JsonSerializer;

namespace StockWatcher
{
    public partial class StockWatcher : Form
    {
        public StockWatcher()
        {
            InitializeComponent();
        }

        private void StockWatcher_Load(object sender, EventArgs e)
        {
            timer1.Interval = SystemSetting.TimerInterval;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var cache = new JsonSerializer();
            var fireAntClient = new FireAntClient(cache, new ErrorLogger());
            var data = new List<StockItem>();
            string symbol = txtSymbol.Text;

            var intradayItems = fireAntClient.GetIntraday(symbol);
            intradayItems.Reverse();
            const string delimiter = "             ";
            const string splitBar = "-------------------";
            var pricing = intradayItems.Select(current => splitBar + Environment.NewLine +
                                                           DateTime.Parse(current.Date).ToString("HH:mm:ss") + delimiter + current.Price + delimiter + current.Volume + delimiter + (current.Side ?? "M/B"))
                                        .Aggregate((current, next) => current + Environment.NewLine + next);
           
            txtPricingQuotes.Text = pricing;

            IntraDayQuotes latestPrice = intradayItems.First();

            var currentPrice = latestPrice.Price;
            var jsonBody = JsonConvert.SerializeObject(latestPrice, Formatting.Indented);
            // check price to BUY 
            if (currentPrice <= float.Parse(txtPriceToBuy.Text))
            {
                string subject = $"BUY {symbol} - {currentPrice}";
                if (chkSendNotification.Checked)
                {
                    SendNotification(subject, $"BUY {symbol} for NOW. <br/>" + jsonBody);
                }
                txtLogging.AppendText($"{DateTime.Now.ToString()} - {subject}" + Environment.NewLine);

                DisableTimer();
            }

            // check price to SELL
            if (currentPrice >= float.Parse(txtPriceToSell.Text))
            {
                string subject = $"SELL {symbol} - {currentPrice}";
                if (chkSendNotification.Checked)
                {
                    SendNotification($"SELL {symbol} - {currentPrice}", $"SELL {symbol} for NOW. <br/>" + jsonBody);
                }
                txtLogging.AppendText($"{DateTime.Now.ToString()} - {subject}" + Environment.NewLine);

                DisableTimer();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EnableTimer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DisableTimer();
        }

        #region  HELPER METHOD

        private void DisableTimer()
        {
            timer1.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }


        private void EnableTimer()
        {
            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private async void SendNotification(string subject, string body)
        {
            var client = new SendGridClient(SystemSetting.SendGridApiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(SystemSetting.SenderEmail, "StockWatcher"),
                Subject = subject,
                HtmlContent = $"<strong>{body}</strong>"
            };

            string email1 = txtEmail1.Text;
            string email2 = txtEmail2.Text;
            string email3 = txtEmail3.Text;

            if(!string.IsNullOrEmpty(email1)) msg.AddTo(new EmailAddress(email1, "Trader1"));
            if(!string.IsNullOrEmpty(email2)) msg.AddTo(new EmailAddress(email2, "Trader2"));
            if(!string.IsNullOrEmpty(email3)) msg.AddTo(new EmailAddress(email3, "Trader3"));
            
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
        }


        #endregion

        
    }
}