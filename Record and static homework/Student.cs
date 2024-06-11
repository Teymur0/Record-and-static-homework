using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_and_static_homework
{
    internal class Student : User
    {
        public Student(string fullName, string email, string password) : base(fullName, email, password)
        {
        }
    }
}
