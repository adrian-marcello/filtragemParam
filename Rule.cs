using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        public bool running { get; set; }
        public TextBox debugBox { get; set; }
        public Mutex mutex { get; set; }
        public List<IED> listaIEDs { get; set; }



        public ConcurrentQueue<PacoteIED> buffer { get; set; }


        public Rule(string p_n, string p_op, int p_valor, Mutex p_mutex, List<IED> p_listaIEDs, TextBox p_debugBox)
        {
            n = p_n;
            op = p_op;
            valor = p_valor;
            running = false;
            buffer = new ConcurrentQueue<PacoteIED>();
            debugBox = p_debugBox;
            mutex = p_mutex;
            listaIEDs = p_listaIEDs;
        }

        public override string ToString()
        {
            return "I" + n + " " + op + " " + valor;
        }

        public void analyzePackets()
        {
            while (running)
            {
                if (buffer.IsEmpty)
                {
                    Thread.Sleep(20);
                }
                else
                {
                    PacoteIED packet = new PacoteIED();
                    if (buffer.TryDequeue(out packet))
                    {
                        if (checkEvent(packet))
                        {
                            debugBox.Text = debugBox.Text + "ativou a regra: "+ ToString() + '\n';
                            mutex.WaitOne();
                            if (listaIEDs.Exists(x => x.id == packet.idDispositivo))
                            {
                                listaIEDs.Find(x => x.id == packet.idDispositivo).somaEvento();
                            }
                            else
                            {
                                IED ied = new IED(packet.idDispositivo,1);
                                listaIEDs.Add(ied);
                            }
                            mutex.ReleaseMutex();
                        }
                    }
                }
            }
            mutex.WaitOne();
            debugBox.Text = debugBox.Text + "fim da thread " + '\n';
            mutex.ReleaseMutex();
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

        
    }
}
