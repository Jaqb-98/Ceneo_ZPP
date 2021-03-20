using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    /// <summary>
    /// Provides method to load item objects from ceneo.pl
    /// </summary>
    public interface IWebsiteParser
    {
        /// <summary>
        /// Returns parsed items from Ceneo
        /// </summary>
        /// <param name="searchedItem">Name of searching product</param>
        /// <param name="page">Number of page on website</param>
        /// <returns>List of items</returns>
        List<Item> GetItems(string searchedItem, int page);
    }
}
