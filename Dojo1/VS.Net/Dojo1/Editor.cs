using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    public class Editor
    {
        public string Digitar(string msg)
        {
            string codigo = "";
            for (int i = 0; i < msg.Length; i++)
            {
                if (i != 0)
                {
                    codigo += "_" + codifica(msg[i]);
                }
                else
                {
                    codigo += "" + codifica(msg[i]);
                }

            }
            return codigo;
        }

        private string codifica(char letra)
        {
            switch (letra.ToString())
            {
                case "A":
                    return "2";
                    break;
                case "B":
                    return "22";
                    break;
                case "C":
                    return "222";
                    break;
                case "D":
                    return "3";
                    break;
                default:
                    return "";
            }
        }
    }
}
