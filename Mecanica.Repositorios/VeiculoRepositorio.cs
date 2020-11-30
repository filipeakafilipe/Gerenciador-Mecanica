using Mecanica.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mecanica.Repositorios
{
    public class VeiculoRepositorio : BaseRepositorio, IVeiculoRepository<Veiculo>
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

        public void Atualizar(int id, Veiculo novoVeiculo)
        {
            var veiculo = Get(id);

            if(veiculo != null)
            {
                veiculo.Ano = novoVeiculo.Ano;
                veiculo.Especificacao = novoVeiculo.Especificacao;
                veiculo.Kilometragem = novoVeiculo.Kilometragem;
                veiculo.Marca = novoVeiculo.Marca;
                veiculo.Modelo = novoVeiculo.Modelo;
                veiculo.Nome = novoVeiculo.Nome;
                veiculo.Placa = novoVeiculo.Placa;

                db.Entry(veiculo).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public List<Veiculo> GetTodos()
        {
            var perfis = db.Perfils.ToList();

            var veiculos = db.Veiculos.ToList();

            veiculos.ForEach(v =>
            {
                v.Perfil = perfis.Where(p => p.Id == v.PerfilId).FirstOrDefault();
            });

            return veiculos.OrderBy(v => v.Placa).ThenBy(v => v.Nome).ThenBy(v => v.Marca).ThenBy(v => v.Modelo).ThenBy(v => v.PerfilId).ToList();
        }

        public List<Veiculo> GetVeiculoCliente(int perfilId)
        {
            return db.Veiculos.Where(v => v.PerfilId == perfilId).ToList();
        }

        public void Remover(int id)
        {
            var veiculo = Get(id);

            if (veiculo != null)
            {
                db.Veiculos.Remove(veiculo);

                db.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
    }
}
