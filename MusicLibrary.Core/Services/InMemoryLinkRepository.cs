using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicLibrary.Core.Model;

namespace MusicLibrary.Core.Services
{
    public class InMemoryLinkRepository : ILinkRepository
    {
        public IEnumerable<Link> GetLinks()
        {
            List<Link> toReturn = new List<Link>();
            toReturn.Add(new Link() 
            { 
                ID = 1,
                Title ="Home",
                Url ="..\\home"
            });
            toReturn.Add(new Link()
            {
                ID = 1,
                Title = "Contacts",
                Url = "..\\contacts"
            });

            return toReturn;
        }
    }
}
