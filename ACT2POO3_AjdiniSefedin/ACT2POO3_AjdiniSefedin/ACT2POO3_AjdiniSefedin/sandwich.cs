using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT2POO3_AjdiniSefedin
{
    internal class sandwich
    {
        private string _viande;
        private string _crudite;
        private string _pain;
        private string _sauce;
        public string Viande
        {
            get { return _viande; }
            set { _viande = value; }
        }

        public string Crudite
        {
            get { return _crudite; }
            set { _crudite = value; }
        }

        public string Pain 
        {
            get { return _pain; }
            set { _pain = value; }
        }

        public string Sauce
        {
            get { return _sauce; }
            set { _sauce = value; }
        }

        public sandwich()
        {
                string[] viande = { "du jambon", "du boeuf", "du cochon", "de la dinde" };
                string[] crudite = { "de la salade", "des carottes", "des ognions", "des oeufs" };
                string[] pain = { "de pain blanc", "de pain carre", "de pain gris", "de pain noir" };
                string[] sauce = { "de la andalouse", "de la samourai", "du ketchup", "de la mayo" };
            
            Random alea = new Random();
            
            int numPlace = alea.Next(0, 3);
            _viande = viande[numPlace];
            numPlace = alea.Next(0, 3);
            _crudite = crudite[numPlace];
            numPlace = alea.Next(0, 3);
            _pain = pain[numPlace];
            numPlace = alea.Next(0, 3);
            _sauce = sauce[numPlace];
        }

        public string ComposeSandwich()
        {
            string chaine = ""+ _pain + "," + _crudite + "," + _viande + "," + _sauce;
            return chaine;
        }
    }
}
