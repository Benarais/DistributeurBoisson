using DistributeurBoisson.Model.Produit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBoisson.Model.Recette
{
    public class Capuccino : Boisson
    {
        public double DeterminerPrix()
        {
            Cafe cafe = new Cafe();
            Chocolat choco = new Chocolat();
            Creme creme = new Creme();
            Eau eau = new Eau();
            return cafe.Prix + choco.Prix + eau.Prix + creme.Prix;
        }
    }
}
