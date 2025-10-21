using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Livro
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? AnoLancamento { get; set; }
        public string? Genero { get; set; }

        public Livro() { }

        public Livro(string titulo, string autor, string anoLancamento, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            AnoLancamento = anoLancamento;
            Genero = genero;
        }

        public override string ToString()
        {
            return $"{Titulo},{Autor},{AnoLancamento},{Genero}";
        }
    }
}
