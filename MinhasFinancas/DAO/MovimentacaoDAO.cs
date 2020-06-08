using MinhasFinancas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhasFinancas.DAO
{
    public class MovimentacaoDAO
    {
        private FinancasContext context;

        public MovimentacaoDAO(FinancasContext context)
        {
            this.context = context;
        }

        public void Adiciona(Movimentacao movimentacao)
        {
            context.Movimentacoes.Add(movimentacao);
            context.SaveChanges();
        }
        public IList<Movimentacao> Lista()
        {
            return context.Movimentacoes.ToList();
        }
        public IList<Movimentacao> BuscaPorUsuario(int? usuarioId)
        {
            return context.Movimentacoes.Where(m => m.UsuarioId == usuarioId).ToList();
        }
    }
}