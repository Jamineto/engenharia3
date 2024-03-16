﻿using EngenhariaWeb.DAO;
using EngenhariaWeb.Models;
using EngenhariaWeb.Util;
using MySql.Data.MySqlClient;

namespace EngenhariaWeb.Controles
{
    public class ProdutoControle
    {
        //colocar a chamada do singleton aqui e passar para a model a conexao
        static List<ProdutoLista> produtosEmEspera = new List<ProdutoLista>();

        public List<Produto> obterProdutos()
        {
            Produto produto = new Produto();
            Singleton instance = Singleton.getInstance();
            MySqlConnection con = instance.ConnectionStart();
            con = instance.ConnectionStart();
            con.Open();
            return produto.obterProdutos(con);
        }

        public Produto obterPorCodigo(int id)
        {
            Produto produto = new Produto();
            Singleton instance = Singleton.getInstance();
            MySqlConnection con = instance.ConnectionStart();
            con = instance.ConnectionStart();
            con.Open();
            return produto.obterPorCodigo(id, con);
        }

        public int obterEstoqueProduto(int id)
        {
            Produto produto = new Produto();
            Singleton instance = Singleton.getInstance();
            MySqlConnection con = instance.ConnectionStart();
            con = instance.ConnectionStart();
            con.Open();
            return produto.obterEstoqueProduto(id, con);
        }

        public void guardaLista(int id, int qtd)
        {
            Produto produto = obterPorCodigo(id);
            ProdutoLista pl = new ProdutoLista();
            pl.prod_codigo = produto.id;
            pl.qtde = qtd;
            pl.valor = produto.preco;
            pl.valorTotal = pl.valor * pl.qtde;
            pl.descricao = produto.descricao;
            produtosEmEspera.Add(pl);

        }

        public List<ProdutoLista> retornaLista()
        {
            return produtosEmEspera;
        }

        public void zeraLista()
        {
            produtosEmEspera.Clear();
        }
    }
}