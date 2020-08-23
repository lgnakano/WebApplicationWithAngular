using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class WeatherForecast
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string Location { get; set; }


    }

    public class SignUp
    {
        [Key]
        public Guid Id { get; set; }     
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public int age { get; set; }
    }
}
