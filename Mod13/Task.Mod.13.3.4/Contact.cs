using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Mod._13._3._4
{
    public class Contact
    {
        public Contact(long phoneNumber, String email) // метод-конструктор
        {
            //Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            //IdKey = idkey;
        }

        //public String Name { get; }
        public long PhoneNumber { get; set; }
        public String Email { get; set; }
        //public int IdKey { get; set; }
    }
}
