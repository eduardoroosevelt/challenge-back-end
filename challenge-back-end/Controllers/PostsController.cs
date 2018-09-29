using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using challenge_back_end.Models;

namespace challenge_back_end.Controllers
{
    public class PostsController : ApiController
    {
        private static List<Posts> listaPosts = new List<Posts>();
        private static int totalLike;
        private static int totalViews;

        public List<Posts> Get()
        {
            return listaPosts;
        }

        public Posts Get(int id)
        {
            int index = getIndex(id);
            View(id);
            return listaPosts.ElementAt(index);
        }

        public void Post(string Titulo, string Descricao, string Conteudo)
        {
            int nextId = listaPosts.Count + 1;
            listaPosts.Add(new Posts(nextId, Titulo, Descricao, Conteudo));
        }

        public void Delete(int id)
        {
            int index = getIndex(id);
            listaPosts.RemoveAt(index);
        }

        [HttpPost]
        public void Like(int id)
        {
            int index = getIndex(id);
            listaPosts.ElementAt(index).qtdLikes++;
            totalLike++;
        }

        public void View(int id)
        {
            int index = getIndex(id);
            listaPosts.ElementAt(index).qtdViews++;
            totalViews++;
        }

        public Decimal porcentagemLike(int id)
        {
            int index = getIndex(id); ;
            return (listaPosts.ElementAt(index).qtdLikes / totalLike) * 100;
        }

        public Decimal porcentagemViews(int id)
        {
            int index = getIndex(id); ;
            return (listaPosts.ElementAt(index).qtdViews / totalViews) * 100;
        }

        private int getIndex(int id)
        {
            return listaPosts.FindIndex(p => p.Id == id);
        }
    }
}
