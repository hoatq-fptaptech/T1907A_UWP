using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1907A.Models
{
    class MenuItem
    {
        char icon;
        string name;

        public MenuItem(char icon, string name)
        {
            Icon = icon;
            Name = name;
        }

        public char Icon
        {
            get => icon;
            set => icon = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
