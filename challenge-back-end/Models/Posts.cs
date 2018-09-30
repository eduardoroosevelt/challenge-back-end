using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace challenge_back_end.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public int qtdViews { get; set; }
        public int qtdLikes { get; set; }
        public double PorcentagemLike { get; set; }
        public double PorcentagemView { get; set; }

        public Posts()
        {

        }
        public Posts(string titulo, string descricao, string conteudo)
        {
           
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Conteudo = conteudo;
            this.qtdLikes = 0;
            this.qtdViews = 0;
            this.PorcentagemLike = 1;
            this.PorcentagemView = 0;
        }

        
    }
}