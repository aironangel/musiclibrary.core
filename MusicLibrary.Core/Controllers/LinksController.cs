using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Core.Services;
using MusicLibrary.Core.Model;

namespace MusicLibrary.Core.Controllers
{
    [Route("api/[controller]")]
    public class LinksController : Controller
    {
        /// <summary>
        /// internale reference to data access
        /// </summary>
        private readonly ILinkRepository _db;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public LinksController(ILinkRepository db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Link> Get()
        {
            return _db.GetLinks();
        }

        [HttpGet("{id}")]
        public Link Get(int id)
        {
            return _db.GetLinks().SingleOrDefault(x => x.ID == id);
        }

    }
}