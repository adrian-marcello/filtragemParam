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
        public int index { get; set; }

        public string texto = "";

        public Rule(string p_n, string p_op, int p_valor)
        {
            n = p_n;
            op = p_op;
            valor = p_valor;

        }

        public bool checkEvent(PacoteIED pacote)
        {
            int param = 0;
            switch (this.n)
            {
                case "a":
                    param = pacote.Ia;
                    break;
                case "b":
                    param = pacote.Ib;
                    break;
                case "c":
                    param = pacote.Ic;
                    break;
            }

            bool flag = false;
            switch (this.op)
            {
                case "<": flag = (param < this.valor); break;
                case "=": flag = (param == this.valor); break;
                case ">": flag = (param > this.valor); break;
            }
            return flag;
        }

        public override string ToString()
        {
            return "I" + n + " " + op + " " + valor;
        }
    }
}
