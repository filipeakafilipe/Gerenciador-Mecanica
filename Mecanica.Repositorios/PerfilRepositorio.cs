using Mecanica.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Mecanica.Repositorios
{
    public class PerfilRepositorio : BaseRepositorio
    {
        public PerfilRepositorio() : base()
        {

        }

        public Perfil Get(int id)
        {
            return db.Perfils.Where(v => v.Id == id).FirstOrDefault();
        }

        public void Adicionar(Perfil perfil)
        {
            db.Perfils.Add(perfil);

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            var perfil = db.Perfils.Where(v => v.Id == id).FirstOrDefault();

            db.Perfils.Remove(perfil);

            db.SaveChanges();
        }

        public void Atualizar(int id, Perfil novoPerfil)
        {
            var perfil = Get(id);

            perfil = novoPerfil;

            db.Entry(perfil).State = EntityState.Modified;

            db.SaveChanges();
        }
    }
}
