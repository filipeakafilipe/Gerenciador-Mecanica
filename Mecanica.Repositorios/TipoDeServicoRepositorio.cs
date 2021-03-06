using Mecanica.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mecanica.Repositorios
{
    public class TipoDeServicoRepositorio : BaseRepositorio, ITipoDeServicoRepository<TipoDeServico>
    {
        public TipoDeServicoRepositorio():base()
        {

        }

        public TipoDeServico Get(int id)
        {
            return db.TipoDeServicos.Where(v => v.Id == id).FirstOrDefault();
        }

        public void Adicionar(TipoDeServico tipoDeServico)
        {
            db.TipoDeServicos.Add(tipoDeServico);

            db.SaveChanges();
        }

        public void Atualizar(int id, TipoDeServico novoTipoDeServico)
        {
            var tipoDeServico = Get(id);

            if (tipoDeServico != null)
            {
                tipoDeServico.Nome = novoTipoDeServico.Nome;
                tipoDeServico.Observacoes = novoTipoDeServico.Observacoes;

                db.Entry(tipoDeServico).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public List<TipoDeServico> GetTodos()
        {
            return db.TipoDeServicos.ToList();
        }

        public void Remover(int id)
        {
            var tipoDeServico = Get(id);

            if (tipoDeServico != null)
            {
                db.TipoDeServicos.Remove(tipoDeServico);

                db.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
    }
}
