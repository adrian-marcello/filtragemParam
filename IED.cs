using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filtragemParam
{
    public class IED
    {

        public int id; //id da IED analisada por essa classe
        public int qtdEventos; //quantidade de eventos encontradas

        public IED(int p_id, int p_qtdEventos)
        {
            id = p_id;
            qtdEventos = p_qtdEventos;
        }
        public int somaEvento()
        {
            qtdEventos++;
            return qtdEventos;
        }


    }
}
