using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentLibrary
{
    public class Person
    {
        private string address_;
        private string firstname_;

        public enum Gender
        {
            Male = 0,
            Female = 1
        }


        public Person()
        {
        }

        public Person(string firstname, string address)
        {
            firstname_ = firstname;
            address_ = address;
        }
       

        
        public string Firstname
        {
            get { return firstname_; }
            set { CheckName(firstname_);
                firstname_ = value;
            }
        }

        public string Address
        {
            get { return address_; }
            set { address_ = value; }
        }


        public void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name must be filled");
            }

        }
    }
}
