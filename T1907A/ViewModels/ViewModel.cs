using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1907A.Models;

namespace T1907A.ViewModels
{
    class ViewModel
    {
        public static List<Mail> MailList = new List<Mail>();
        public ViewModel()
        {
            if(MailList.Count == 0)
            {
                MailList.Add(new Mail("quanghoa@gmail.com",
                "Thu moi", "thu moi"));
                MailList.Add(new Mail("quanghoa@gmail.com",
                    "Thu moi", "thu moi"));
            }
            
        }

        public List<Mail> Mails
        {
            get=> MailList;
        } 
    }
}
