using Mecanica.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Mecanica.Repositorios
{
    public class VeiculoRepositorio : BaseRepositorio
    {
        public VeiculoRepositorio() : base()
        {
        }

        public Veiculo Get(int id)
        {
            return db.Veiculos.Where(v => v.Id == id).FirstOrDefault();
        } 

        public void Adicionar(Veiculo veiculo)
        {
            db.Veiculos.Add(veiculo);

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            var veiculo = db.Veiculos.Where(v => v.Id == id).FirstOrDefault();

            db.Veiculos.Remove(veiculo);

            db.SaveChanges();
        }

        public void Atualizar(int id, Veiculo novoVeiculo)
        {
            var veiculo = Get(id);

            veiculo = novoVeiculo;

            db.Entry(veiculo).State = EntityState.Modified;

            db.SaveChanges();
        }
    }
}
