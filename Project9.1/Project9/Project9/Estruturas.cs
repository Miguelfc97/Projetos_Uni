using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9
{
    public struct Aluno
    {
        public int numero;
        public string nome;
    }

    public struct Curso
    {
        public int codigo;
        public string descricao;
    }

    public struct ImportExport
    {
        public Aluno[] a;
        public Curso[] c;
    }

}
