using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermProgFinalProject
{
    class Transaction
    {
        private string amount;
        private string date;

        // get;set for amount
        public void setAmount(string amount)
        {
            this.amount = amount;
        }
        public string getAmount()
        {
            return amount;
        }

        // get;set for date
        public void setDate(string date)
        {
            this.date = date;
        }
        public string getDate()
        {
            return date;
        }
    }
}
