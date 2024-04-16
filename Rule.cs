using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filtragemParam
{
    internal class Rule
    {
        public string n { get; set; }
        public string op { get; set; }
        public int valor { get; set; }

        public string texto = "";

        public Rule(string p_n, string p_op, int p_valor)
        {
            n = p_n;
            op = p_op;
            valor = p_valor;

            texto = "I" + n + " " + op + " " + valor;

        }

        public bool checkEvent(int recValue)
        {
            switch (this.op)
            {
                case "<":
                    return recValue < this.valor;
                case "=":
                    return recValue == this.valor;
                case ">":
                    return recValue > this.valor;
                default:
                    return false;
            }
        }
    }
}
