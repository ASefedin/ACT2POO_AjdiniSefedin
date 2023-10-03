using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT2POO3_AjdiniSefedin
{
    internal class sandwich
    {
        private string[] _viande = { "jambon", "boeuf", "cochon", "dinde" };
        private string[] _crudite = { "salade", "carotte", "ognion", "oeuf" };
        private string[] _pain = { "pain blanc", "pain carre", "pain gris", "pain noir" };
        private string[] _sauce = { "andalouse", "samourai", "ketchup", "mayo" };

        public int[] Viande
        {
            get { return _viande; }
            set { _viande = value; }
        }

    }
}
