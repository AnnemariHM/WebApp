using WebApp.Models;
using System.Collections.Generic;

namespace WebApp.Services
{
    public class LeffaService
    {
        //Muuttujat
        private readonly List<Leffa> _leffat;

        //Konstruktori
        public LeffaService()
        {
            _leffat = new List<Leffa>();
        }

        //Leffan lisääminen listaan
        public void AddLeffa(Leffa leffa)
        {
            _leffat.Add(leffa);
        }

        //Leffojen palauttaminen palvelimelle
        public IList<Leffa> GetLeffa()
        {
            return _leffat;
        }

        //Leffojen poistaminen listalta
        public void DeleteLeffa(int id)
        {
            var leffa = _leffat.Find(l => l.Id == id);
            if (leffa != null)
            {
                _leffat.Remove(leffa);
            }
        }
    }
}
