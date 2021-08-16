using DistributeurBoisson.Model;
using DistributeurBoisson.Model.Recette;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DistributeurBoisson.ViewModel
{
    public class AfficherPrix
    {
        public ObservableCollection<String> boissons { get; private set; }

        public AfficherPrix()
        {
            boissons = new ObservableCollection<string>();
            ChargerBoissons(boissons);
        }

        private void ChargerBoissons(ObservableCollection<string> boissons)
        {
            foreach (var recette in Enum.GetValues(typeof(BoissonsEnum)))
            {
                boissons.Add(recette.ToString());
            }
        }

        internal string determinerPrix(string boissonChoisie)
        {
            if (boissonChoisie == "Expresso")
            {
                Expresso expresso = new Expresso();
                return expresso.DeterminerPrix().ToString();
            }
            else if (boissonChoisie == "Allongé")
            {
                Allonge allonge = new Allonge();
                return allonge.DeterminerPrix().ToString();
            }
            else if (boissonChoisie == "Capuccino")
            {
                Capuccino capuccino = new Capuccino();
                return capuccino.DeterminerPrix().ToString();
            }
            else if (boissonChoisie == "Chocolat")
            {
                ChocolatChaud chocolat = new ChocolatChaud();
                return chocolat.DeterminerPrix().ToString();
            }
            else if (boissonChoisie == "Thé")
            {
                TheRecette the = new TheRecette();
                return the.DeterminerPrix().ToString();
            }
            else
            {
                throw new Exception("Boisson inconnue ?");
            }
        }
    }
}
