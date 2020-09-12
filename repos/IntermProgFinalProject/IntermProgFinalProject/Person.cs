using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermProgFinalProject
{
    class Person 
    {
        private string firstName;
        private string lastName;
        private string ssn;
        private string dateOfBirth;
        private string userId;
        private string streetAddress;
        private string city;
        private string state;
        private string zipcode;

        // get;set for firstName
        public void setFirstName(string firstname)
        {
            this.firstName = firstname;
        }
        public string getFirstName()
        {
            return firstName;
        }

        // get;set for lastName
        public void setLastName(string lastname)
        {
            this.lastName = lastname;
        }
        public string getLastName()
        {
            return lastName;
        }

        // get;set for ssn
        public void setSSN(string ssn)
        {
            this.ssn = ssn;
        }
        public string getSSN()
        {
            return ssn;
        }

        // get;set for date of birth
        public void setDateOfBirth(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public string getDateOfBirth()
        {
            return dateOfBirth;
        }

        // get;set for userID
        public void setUserID(string userId)
        {
            this.userId = userId;
        }
        public string getUserID()
        {
            return userId;
        }

        // get;set for street address
        public void setStreetAddress(string streetAddress)
        {
            this.streetAddress = streetAddress;
        }
        public string getStreetAddress()
        {
            return streetAddress;
        }

        // get;set for city
        public void setCity(string city)
        {
            this.city = city;
        }
        public string getCity()
        {
            return city;
        }

        // get;set for state
        public void setState(string state)
        {
            this.state = state;
        }
        public string getState()
        {
            return state;
        }

        // get;set for zipcode
        public void setZipCode(string zipcode)
        {
            this.zipcode = zipcode;
        }
        public string getZipCode()
        {
            return zipcode;
        }
    }
}
