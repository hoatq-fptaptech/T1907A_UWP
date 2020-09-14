using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Models
{
    class MenuItem
    {
        private string name;
        private string code;
        private string icon;

        public MenuItem(string name, string code, string icon)
        {
            Name = name;
            Code = code;
            Icon = icon;
        }

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public string Icon { get => icon; set => icon = value; }
    }
}
