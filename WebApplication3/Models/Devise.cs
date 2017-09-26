using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Devise
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public double Taux { get; set; }

        public Devise()
        {
                
        }

        public Devise(int Id, String Nom, double Taux)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Taux = Taux;
        }





    }
}