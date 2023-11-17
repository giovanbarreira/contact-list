using Microsoft.WindowsAppSDK.Runtime.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_list.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }

        public Contact(string name, string email, string phone, string webSite)
        {
            Name = name;
            Email = email;
            Phone = phone;
            WebSite = webSite;
        }
    }
}
