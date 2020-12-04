using App.Modelos;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace App.Services
{
    public static class PerfilService
    {
        public static async Task Cadastrar(Perfil perfil)
        {
            try
            {
                await $"{Base.Uri}api/perfil".PostJsonAsync(perfil);
            }
            catch
            {
                throw new Exception();
            }
        }

        public static Task<List<Perfil>> GetPerfis()
        {
            try
            {
                return $"{Base.Uri}api/perfil/todos".GetJsonAsync<List<Perfil>>();
            }
            catch
            {
                throw new Exception();
            }
        }

        public static async Task Alterar(Perfil perfil)
        {
            try
            {
                await $"{Base.Uri}api/perfil/".PutJsonAsync(perfil);
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }

        public static async Task Deletar(int id)
        {
            try
            {
                await $"{Base.Uri}api/perfil/{id}".DeleteAsync();
            }
            catch
            {
                throw new Exception();
            }
        }

        public static async Task<Perfil> Logar(Perfil perfil)
        {
            try
            {
                string url = $"{Base.Uri}api/perfil/logar/{perfil.Login}/{perfil.Senha}";

                var result = url.GetJsonAsync<Perfil>().Result;

                return result;
            }
            catch (FlurlHttpException ex) when (ex.Call.HttpStatus == HttpStatusCode.NotFound)
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
