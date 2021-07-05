using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_9
{
 
        public struct alunos
        {
            public int numero;
            public string nome;
        }
        
        public struct curso
        {
            public int codigo;
            public string descricao;
        }

        public struct ImportExport
        {
            public alunos[] a;
            public curso[] c;
        }

}
