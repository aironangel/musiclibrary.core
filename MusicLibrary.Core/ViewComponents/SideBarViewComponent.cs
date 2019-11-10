using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Core.ViewComponents
{
    /// <summary>
    /// Side bar view
    /// </summary>
    public class SideBarViewComponent : ViewComponent
    {
        /// <summary>
        /// internal reference to the link repository
        /// </summary>
        private readonly ILinkRepository _db;
        internal SideBarViewComponent(ILinkRepository db)
        {
            _db = db;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(int max = 10)
        {
            var items = _db.GetLinks().Take(max);
            return View(items);
        }
    }
}
