using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSBL
{
    class Exemplar
    {
        public bool dobra { get; set; }
        public bool anotacao { get; set; }
        public string situacao { get; set; }
        public string entrega { get; set; }
        public Livro livro { get; set; }
        public Responsavel responsavel { get; set; }


        public bool cadastrarExemplar()
        {
            return true;
        }

    }
}
