using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project10
{
    public enum Estado
    {
        verde = 0,
        Amarelo,
        AmareloCastanho,
        CastanhoAmarelo,
        Castanho,
        Preto
    }

    public struct Banana
    {
        public string casca;
        public string miolo;
        public Estado estado;
    }

    public class Cacho
    {
        Banana[] itens;
        

        public Cacho(int n)
        {
            int i = 0;
            Array.Resize<Banana>(ref itens, n);
            for (i = 0; i < n; i++)
            {
                itens[i].casca = "Casca" + i.ToString();
                itens[i].miolo = "miolo" + i.ToString();
                itens[i].estado = Estado.verde;
            } 
        }

        public void Comer()
        {
            int i = itens.Length - 1;
            if (i >= 0)
                Array.Resize<Banana>(ref itens, i);
        }

        public int Tamanho()
        {
            return itens.Length;

        }

        public void Envelhecer()
        {
            Random k = new Random();
            for (int i =0; i<itens.Length; i++)
            {
               if(k.NextDouble()>0.5)
                   switch (itens[i].estado)
                   {
                       case Estado.verde:
                           itens[i].estado = Estado.Amarelo;
                           break;
                       case Estado.Amarelo:
                           itens[i].estado = Estado.AmareloCastanho;
                           break;
                       case Estado.AmareloCastanho:
                           itens[i].estado = Estado.CastanhoAmarelo;
                           break;
                       case Estado.CastanhoAmarelo:
                           itens[i].estado = Estado.Castanho;
                           break;
                       case Estado.Castanho:
                           itens[i].estado = Estado.Preto;
                           break;
                   }
            }

        }
        public string Listar()
        {
            string res = "";
            foreach (Banana b in itens)
                res += b.miolo + " " + b.estado.ToString() + ";";
            return res;
        }
    }
}
