using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace App.Services
{
    public class Base
    {
        // Local: Utilizar seu IP configurado em Mecanica.API.Properties.launchSettings, em "Mecanica.API" > "applicationUrl"
        public static string Uri = "http://192.168.15.27:5000/";

        //public static string Uri = "https://apimecanica.azurewebsites.net/";
    }
}
