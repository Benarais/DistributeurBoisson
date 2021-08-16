using DistributeurBoisson.Model.Produit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBoisson.Model.Recette
{
    public class ChocolatChaud : Boisson
    {
        public double DeterminerPrix()
        {
            Chocolat choco = new Chocolat();
            Lait lait = new Lait();
            Eau eau = new Eau();
            Sucre sucre = new Sucre();
            return 3 * choco.Prix + 2 * lait.Prix + eau.Prix + sucre.Prix;
        }
    }
}
