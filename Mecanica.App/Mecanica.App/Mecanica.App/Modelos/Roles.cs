using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica.App.Modelos
{
    public class Roles
    {
        public Dictionary<string, int> Nomes;

        public Roles()
        {
            Nomes = new Dictionary<string, int>
            {
                {"Administrador", 1 },
                {"Mecânico", 2 },
                {"Cliente", 3 }
            };
        }
    }
}
