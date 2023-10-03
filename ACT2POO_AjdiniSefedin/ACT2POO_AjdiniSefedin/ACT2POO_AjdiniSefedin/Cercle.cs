using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT2POO_AjdiniSefedin
{
    internal class Cercle
    {
        private double _rayon;


    	public double Rayon
		{
			get { return _rayon; }
			set { _rayon = value; }
		}


        public Cercle(double rayon)
        {
            _rayon = rayon;
        }

        public double CalculerPerimetre()
        {
            double value = 2 * Math.PI * _rayon;
            return value;
        }

        public double CalculerAire()
        {
            double value = Math.PI * _rayon * _rayon;
            return value;
        }

        public string AfficherCaracteristiques()
        {
            string chaine = "Le cercle de rayon " + _rayon + " a un perimetre de " + CalculerPerimetre() + " et une aire de " + CalculerAire();
            return chaine;
        }

        public string AfficherCaracteristiquesDivise2()
        {
            string chaineDiv2 = "Le cercle de rayon " + _rayon/2 + " a un perimetre de " + CalculerPerimetre () / 2 + " et une aire de " + CalculerAire() / 2;
            return chaineDiv2;
        }

    }
}
