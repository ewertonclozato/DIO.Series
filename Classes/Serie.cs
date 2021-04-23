using System;
using DIO.Series.Enum;

namespace DIO.Series.Classes
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        //Metodos
        public Serie()
        {

        }
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }
        public override string ToString()
        {
            string retorno = string.Empty;
            retorno += $"Gênero: {this.Genero}{Environment.NewLine}";
            retorno += $"Título: {this.Titulo}{Environment.NewLine}";
            retorno += $"Descrição: {this.Descricao}{Environment.NewLine}";
            retorno += $"Ano de Início: {this.Genero}";
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
    }
}