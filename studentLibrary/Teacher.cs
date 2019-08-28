using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentLibrary
{
    public class Teacher
    {
        private int _id;
        private string _address;
        private string firstName_;
        private double salary_;

        public enum Gender
        {
            Male = 0,
            Female = 1
        }
 


        public Teacher()
        {
        }

        public Teacher( string firstname, double salary)
        {
            CheckSalary(salary);
            CheckName(firstname);
            firstName_ = firstname;
            salary_ = salary;
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (value == null)
                    throw new Exception("Address does not accept null values");
                Address = value;
            }
        }

        public string FirstName
        {
            get { return firstName_; }
            set { CheckName(value);
                firstName_ = value;
            }
        }

       
        public double Salary
        {
            get { return salary_; }
            set { CheckSalary(value);
                salary_ = value;
            }
        }

        public int Id
        {
            get { return _id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ID must be above 1");
                }

                Id = value;
            }
        }


        public void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name must be filled");
            }
        }

        public void CheckSalary(double salary)
        {
            if (salary < 0)
            {
                throw new ArgumentOutOfRangeException("salary", salary, "salary must be positive");
            }
        }

        public override string ToString()

        {
            return string.Format("Teacher({0},{1})", FirstName, Salary);
        }

        public override bool Equals(object obj)
        {
            var item = obj as Teacher;
            item.Id = 1;
            if (item == null)
            {
                return false;
            }

            return this.Id.Equals(item.Id);
        }


        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }


    }
}
