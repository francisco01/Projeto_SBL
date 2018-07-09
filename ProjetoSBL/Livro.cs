using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSBL
{
    class Livro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editora { get; set; }
        public string edicao { get; set; }
        public string ano { get; set; }
        public string tipo { get; set; }
        public Preco preco { get; set; }
        public Lista_ind lista { get; set; }
    }
}
