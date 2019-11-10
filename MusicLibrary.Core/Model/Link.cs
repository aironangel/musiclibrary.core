using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Core.Model
{
    /// <summary>
    /// Menu item
    /// </summary>
    public class Link
    {
        /// <summary>
        /// ID of the link
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        ///  description
        /// </summary>
        public string Title { get; set; }
    }
}
