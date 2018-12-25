using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.Response.Ethereum
{
    public class AddressBalance
    {
        public string address { get; set; }
        public float total_received { get; set; }
        public int total_sent { get; set; }
        public int balance { get; set; }
        public int unconfirmed_balance { get; set; }
        public int final_balance { get; set; }
        public int n_tx { get; set; }
        public int unconfirmed_n_tx { get; set; }
        public int final_n_tx { get; set; }
    }
}
