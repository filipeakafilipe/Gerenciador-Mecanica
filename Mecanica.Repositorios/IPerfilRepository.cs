﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica.Repositorios
{
    public interface IPerfilRepository<T>
    {
        public T Get(int id);
        public T Get(string login);
        void Adicionar(T entidade);
        void Remover(int id);
        void Atualizar(int id, T entidade);
        List<T> GetTodos();
        T Login(string login, string senha);
    }
}
