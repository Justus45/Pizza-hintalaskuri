using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Koe3
{
    public class Pizza
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }
        public int LisaTaytteet { get; set; }

        public Pizza(string nimi, double hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
            LisaTaytteet = 0;
        }
    }
    public class Juomat
    {
        public string Koko { get; set; }
        public double Hinta { get; set; }
        public Juomat(string koko, double hinta)
        {
            Koko = koko;
            Hinta = hinta;
        }  
        
    
    List<Pizza> Pizzat = new List<Pizza>
    {
        new Pizza("Pizza1", 8.50),
        new Pizza("Pizza2", 9.00),
        new Pizza("Pizza3", 10.50),
        new Pizza("Pizza4", 9.50),
        new Pizza("Pizza5", 11.00),
        new Pizza("Pizza6", 11.69),
        new Pizza("Pizza7", 8.00),
        new Pizza("Pizza8", 13.00),
        new Pizza("Pizza9", 11.50),
        new Pizza("Pizza10",15.10)
    };

        List<Juomat> juomat = new List<Juomat>
        {
            new Juomat("Kokis 0.5l", 2.00),
            new Juomat("Kokis 1.5l", 3.50)
        };
    }

}
            
            

            

    

