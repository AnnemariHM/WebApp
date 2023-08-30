using WebApp.Models;
using System.Collections.Generic;

namespace WebApp.Services
{
    public class LeffaService
    {
        private readonly List<Leffa> _leffat;

        public LeffaService()
        {
            _leffat = new List<Leffa>();
        }

        public IList<Leffa> GetLeffa()
        {
            return _leffat;
        }

        public void AddLeffa(Leffa leffa)
        {
            _leffat.Add(leffa);
        }

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
