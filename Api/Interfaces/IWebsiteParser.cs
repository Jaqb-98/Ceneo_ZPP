using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    public interface IWebsiteParser
    {
        List<Item> GetItems(string searchedItem, int page);
    }
}
