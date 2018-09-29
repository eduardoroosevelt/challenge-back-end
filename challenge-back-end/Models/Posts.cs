using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace challenge_back_end.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public int qtdViews { get; set; }
        public int qtdLikes { get; set; }
        public decimal PorcentagemLike { get; set; }
        public decimal Porcentagem_view { get; set; }

        public Posts(int id, string titulo, string descricao, string conteudo)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Conteudo = conteudo;
        }
    }
}