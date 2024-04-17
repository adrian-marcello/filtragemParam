using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filtragemParam
{
    internal class IED
    {

        public int id; //id da IED analisada por essa classe
        public int qtdEventos; //quantidade de eventos encontradas

        public IED(int id, int qtdEventos)
        {
            this.id = id;
            this.qtdEventos = qtdEventos;
        }
        public int somaEvento()
        {
            this.qtdEventos++;
            return this.qtdEventos;
        }


    }
}
