using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_telecomando
{
    internal class Class1
    {
        //immutabili
        private string produttore;
        private string modello;
        private string modalita;

        //mutabili
        private int canale;
        private int volume;
        private bool stato;

        public Class1()
        {

        }

        public void setcanale(string cambio)
        {
            canale = int.Parse(cambio);
        }

        public int getcanale()
        {
            int a=canale;
            return a;
        }
    }
}
