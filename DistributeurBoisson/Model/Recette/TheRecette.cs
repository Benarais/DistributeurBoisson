using DistributeurBoisson.Model.Produit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBoisson.Model.Recette
{
    public class TheRecette : Boisson
    {
        public double DeterminerPrix()
        {
            The the = new The();
            Eau eau = new Eau();
            return the.Prix + 2*eau.Prix;
        }
    }
}
