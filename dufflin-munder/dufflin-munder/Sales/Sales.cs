using System;
using System.Collections.Generic;
using System.Text;

namespace dufflin_munder.Sales
{
    class Sales
    {
        public string SalesAgent;
        public string Client;
        public string ClientID;
        public double Sale;
        public string Recurring;
        public string TimeFrame;

        public Sales(string salesAgent, string client, string clientID, double sale, string recurring, string timeFrame)
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
