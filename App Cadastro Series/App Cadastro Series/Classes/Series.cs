
using System;
namespace App_Cadastro_Series.Classes
{
    public class Series : Entidade
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descrição { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            ID = id;
            Genero = genero;
            Titulo = titulo;
            Descrição = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
   
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descrição + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public int RetornaAno()
        {
            return Ano;
        }
        public string RetornaTitulo()
        {
            return Titulo;
        }

        public int RetornaID()
        {
            return ID;
        }

        internal object retornaExcluido()
        {
            return Excluido;
        }

        public void Exclui()
        {
            Excluido = true;
        }
    }
   
}
