using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermProgFinalProject
{
    class BankAccount
    {
        private Person person;
        private Transaction transaction;

        public BankAccount()
        {
            person = new Person();
            transaction = new Transaction();
        }

        public void setPerson(Person person)
        {
            this.person = person;
        }
        public Person getPerson()
        {
            return person;
        }

        public void setTransaction(Transaction transaction)
        {
            this.transaction = transaction;
        }
        public Transaction getTransaction()
        {
            return transaction;
        }
    }
}
