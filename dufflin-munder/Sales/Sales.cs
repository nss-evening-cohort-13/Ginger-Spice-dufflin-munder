using System;
using System.Collections.Generic;
using System.Text;

namespace dufflin_munder.Sales
{
    class NewSales
    {
        public string SalesAgent { get; set; }
        public string Client { get; set; }
        public string ClientID { get; set; }
        public double Sale { get; set; }
        public string Recurring { get; set; }
        public string TimeFrame { get; set; }

        public NewSales(string salesAgent, string client, string clientID, double sale, string recurring, string timeFrame)
        {
            SalesAgent = salesAgent;
            Client = client;
            ClientID = clientID;
            Sale = sale;
            Recurring = recurring;
            TimeFrame = timeFrame;
            
        }

    }
}
