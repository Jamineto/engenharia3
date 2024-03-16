using EngenhariaWeb.Controles;
using EngenhariaWeb.Models;
using EngenhariaWeb.Util;
using Microsoft.AspNetCore.Mvc;

namespace EngenhariaWeb.Controllers
{
    public class ProdutoController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<Produto> obterProdutos()
        {
            ProdutoControle proControle = new ProdutoControle();
            List<Produto> listaProdutos = proControle.obterProdutos();
            return listaProdutos;
        }

        [HttpGet]
        public List<ProdutoLista> obterProdutosVenda()
        {          
            ProdutoControle pc = new ProdutoControle();
            return pc.retornaLista();
        }

        [HttpGet]
        public Object obterPorCodigo(int id)
        {
            ProdutoControle proControle = new ProdutoControle();
            Produto produto = proControle.obterPorCodigo(id);
            return produto;
        }

        [HttpGet]
        public int obterEstoqueProduto(int id)
        {
            ProdutoControle proControle = new ProdutoControle();
            int estoque = proControle.obterEstoqueProduto(id);
            return estoque;
        }

        public void guardaItens(int id, int qtd)
        {
            ProdutoControle proControle = new ProdutoControle();
            proControle.guardaLista(id, qtd);            
        }

        public void zeraLista()
        {
            ProdutoControle produtoControle = new ProdutoControle();
            produtoControle.zeraLista();
        }
    }
}
