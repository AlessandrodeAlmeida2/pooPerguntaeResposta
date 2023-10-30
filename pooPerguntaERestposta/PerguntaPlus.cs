using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaERestposta
{
    public class PerguntaPlus : Pergunta
    {
        public PerguntaPlus():base()
        {
            //this.Texto = "";
            //this.Resposta = "";
            this.Dica = "";
        }

        public PerguntaPlus(String texto, String resposta, String dica):base(texto, resposta)
        {
            this.Dica = dica;
        }

        public String Dica { get; set; }
    }
}
