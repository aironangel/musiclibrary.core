using MusicLibrary.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Core.Services
{
    /// <summary>
    /// interface for link item's repository
    /// </summary>
    public interface ILinkRepository
    {
        IEnumerable<Link> GetLinks();
    }
}
