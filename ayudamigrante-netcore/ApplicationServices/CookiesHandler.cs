using Microsoft.AspNetCore.Http;
using System.Linq;

namespace ayudamigrante_netcore.ApplicationServices
{
    public class CookiesHandler
    {
        /// <summary> Determina si existe una Cookie determinada en el cliente </summary>
        public static bool CookieExist(HttpRequest req, string key) => req.Cookies.Keys.Contains(key);

        /// <summary> Obtiene el valor de una Cookie determinada del cliente </summary>
        public static string GetValue(HttpRequest req, string key) => req.Cookies.Single(x => x.Key == key).Value;
        public static void AddCookie(string key, string value)
        {

        }
    }
}