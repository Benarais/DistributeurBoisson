using DistributeurBoisson.Model.Produit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBoisson.Model.Recette
{
    public class Expresso : Boisson
    {
        public double DeterminerPrix()
        {
            Cafe cafe = new Cafe();
            Eau eau = new Eau();
            return cafe.Prix + eau.Prix;
        }
    }
}
