using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaERestposta
{
    public class Pergunta
    {
        public Pergunta()
        {
            this.Texto = "";
            this.Resposta = "";
        }

        public Pergunta(string texto, String resposta)
        {
            this.Texto = texto;
            this.Resposta = resposta;
        }

        public String Texto { get; set; }

        public String Resposta { get; set; }
    }
}
