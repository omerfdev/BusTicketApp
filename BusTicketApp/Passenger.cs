using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApp
{
    internal class Passenger
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNumber { get; set; }
        public string PassengerGender { get; set; }

        private string _id;
        public string ID { get { _id = Name.Substring(0, 1).ToUpper() + TelephoneNumber.Substring(0, 5); return _id; } private set {; } }
    }
}
