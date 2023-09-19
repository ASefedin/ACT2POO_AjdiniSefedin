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
        private double _perimetre;
        private double _aire;


    	public double Rayon
		{
			get { return _rayon; }
			set { _rayon = value; }
		}

        public double Perimetre
        {
            get { return _perimetre; }
            set { _perimetre = value; }
        }


        public double Aire
        {
            get { return _aire; }
            set { _aire = value; }
        }

        public void CalculerPerimetre(double rayon)
        {
            
        }

        public void CalculerAire(double rayon)
        {
            
        }

        public string AfficherCaracteristiques()
        {
            string chaine = " Le cercle de rayon " + _rayon + " a un perimetre de " + _perimetre + " et une aire de " + _aire;
            return chaine;
        }

        public string AfficherCaracteristiquesDivise2()
        {
            string chaineDiv2 = " Le cercle de rayon " + _rayon/2 + " a un perimetre de " + _perimetre/2 + " et une aire de " + _aire/2;
            return chaineDiv2;
        }

    }
}
