using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentLibrary
{
    public class Student
    {

        private int _id;

        private string _firstname;

        private string address_;

        private int semester_;

        public Student()
        {
        }

        public Student(string firstName, int semester)
        {
            CheckName(firstName);
            CheckSemester(semester);
            _firstname = firstName;
            semester_ = semester;
        }

        public int Semester
        {
            get { return semester_; }
            set { CheckSemester(value);
                semester_ = value;
            }
        }

        public string Address
        {
            get { return address_; }
            set { address_ = value; }
        }

        

        public string Firstname
        {
            get { return _firstname; }
            set { CheckName(value);
                _firstname = value;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name must be filled");
            }
        }

        public void CheckSemester(int semester)
        {
            if (1 <= semester && semester <= 8)
            {
                throw new ArgumentException("Wooow");
            }
        }
    }


    public enum Gender
    {
        Male = 0,
        Female = 1
       
    }


}
