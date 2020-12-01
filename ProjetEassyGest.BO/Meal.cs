using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class Meal
    {
        public int IdMeal { get; set; }

        public byte[] Picture { get; set; }

        public string NameMeal { get; set; }

        public int PriceMeal { get; set; }

        public string Attribut { get; set; }

        public Meal()
        {
        }

        public Meal(int idMeal, byte[] picture, string nameMeal, int priceMeal, string attribut)
        {
            IdMeal = idMeal;
            Picture = picture;
            NameMeal = nameMeal;
            PriceMeal = priceMeal;
            Attribut = attribut;
        }
    }
}
