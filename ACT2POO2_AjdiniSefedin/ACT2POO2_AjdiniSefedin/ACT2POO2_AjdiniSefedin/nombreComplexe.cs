using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT2POO2_AjdiniSefedin
{
    internal class nombreComplexe
    {
        private double _reel = 10;
        private double _imaginaire = 2;

        public double Reel
        {
            get { return _reel; }
            set { _reel = value; }
        }

        public double Imaginaire
        {
            get { return _imaginaire; }
            set { _imaginaire = value; }
        }

        public nombreComplexe(double reel, double imaginaire)
        {
            _reel = reel;
            _imaginaire = imaginaire;
        }

        public double Module()
        {
            double module = Math.Sqrt(Math.Pow(Reel, 2) + Math.Pow(Imaginaire, 1));
            return module;
        }


        public void ajoute(nombreComplexe c)
        {
            _reel += c.Reel;
            _imaginaire += c.Imaginaire;
        }
        public string AfficheComplexe()
        {
            string chaine = "premier complexe" + _reel + "deuxieme complexe" + _imaginaire;
            return chaine;
        }

        public string AfficheModule()
        {
            string chaine = "module = " + Module();
            return chaine;
        }

    }
}
