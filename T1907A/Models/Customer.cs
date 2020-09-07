using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1907A.Models
{
    public class Customer
    {
        private string fullName;
        private string telePhone;
        private int age;
        private DateTime birthday;

        public Customer(string fullName, string telePhone, int age, DateTime birthday)
        {
            FullName = fullName;
            TelePhone = telePhone;
            Age = age;
            Birthday = birthday;
        }

        public string FullName
        {
            get => fullName;
            set => fullName = value;
        }

        public string TelePhone
        {
            get => telePhone;
            set => telePhone = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public DateTime Birthday
        {
            get => birthday;
            set => birthday = value;
        }

        public string ToString()
        {
            return FullName + "--" + TelePhone +
                "--" + Age + "--" + Birthday.ToString()+"\n";
        }
    }
}
