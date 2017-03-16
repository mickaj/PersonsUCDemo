using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsUCDemo.Model
{
    public class Person
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {                                   
                lastName = value;
            }
        }

        private uint born;

        public uint Born
        {
            get
            {
                return born;
            }
            set
            {
                born = value;
            }
        }

        private string occupation;

        public string Occupation
        {
            get
            {
                return occupation;
            }
            set
            {
                occupation = value;
            }
        }

        private decimal balance;

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public Person(string _name, string _lname, uint _year, string _occupation, decimal _balance)
        {
            FirstName = _name;
            LastName = _lname;
            Born = _year;
            Occupation = _occupation;
            Balance = _balance;
        }     
    }
}
