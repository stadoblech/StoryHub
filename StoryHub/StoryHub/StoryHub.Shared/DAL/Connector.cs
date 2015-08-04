using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Windows.Data.Xml.Dom;

namespace StoryHub.DAL
{
    class Connector
    {
        private static string DATABASE_NAME = "";
        private static string DATABASE_PSW = "";
        private static Uri URI = new Uri("ů");

        /// <summary>
        /// Metoda pro připojení k databázi. Pouze otevře spojení s databází.
        /// </summary>
        private void connect() 
        {
            try
            {
                HttpClient client = new HttpClient();
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// Metoda k protlačení informací na server. Informace přijme z parseru serializované do xml a tady je přeloží do databáze.
        /// </summary>
        /// <param name="doc"></param>
        public void Push(XmlDocument doc) { }
        /// <summary>
        /// Metoda pro stažení xml informací ze serveru. Metoda stáhne nový obsah ze serveru a vrátí ho v xml. Parser může potom toto deserializovat.
        /// </summary>
        /// <returns></returns>
        public XmlDocument Pull() { return new XmlDocument(); }
    }
}
