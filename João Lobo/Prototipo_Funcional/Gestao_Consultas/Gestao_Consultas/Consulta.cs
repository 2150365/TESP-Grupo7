using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Consultas
{
    class Consulta
    {
        private string _caso;

        private string _outro;





        public Consulta(String caso, String outro)
        {
            this._caso = caso;
            this._outro = outro;


            List<Consulta> mylist = new List<Consulta>();

        }


        public override string ToString()
        {
            return _caso + " ( " + _outro;
        }
    }
}
