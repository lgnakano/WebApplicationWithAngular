using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class SignUp
    {
        [Key]
        public Guid Id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string location { get; set; }

        public int locationID { get; set; }

        public int age { get; set; }
       
        public List<Flight> Flights { get; set; }
    }

    public class Airport
    {

        public string location { get; set; }

        public int locationID { get; set; }

        public string AirportName { get; set; }
        [Key]
        public int AirportID { get; set; }

        
        public List<Flight> Flights { get; set; }
    }

    public class Flight
    {
        public int locationID { get; set; }
        [Key]
        public int flightnum { get; set; }

        public string airline { get; set; }

    }
}




