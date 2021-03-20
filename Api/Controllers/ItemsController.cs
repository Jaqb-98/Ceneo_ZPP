using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helper;
using Api.Interfaces;

namespace Api.Controllers
{
    /// <summary>
    /// Provides REST operations
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsService _itemsService;
        private readonly IWebsiteParser _websiteParser;


        /// <summary>
        /// Controller constructor with services as parameters
        /// </summary>
        /// <param name="itemsService"></param>
        /// <param name="websiteParser"></param>
        public ItemsController(IItemsService itemsService, IWebsiteParser websiteParser)
        {
            _itemsService = itemsService;
            _websiteParser = websiteParser;
        }


        [HttpGet]
        public ActionResult<List<Item>> Get() =>
            _itemsService.Get();

        [HttpGet("{id}", Name = "GetItem")]
        public ActionResult<Item> Get(int id)
        {
            var item = _itemsService.Get(id);

            if (item == null)
                return NotFound();

            return item;
        }

        [HttpGet]
        [Route("GetFromDB")]
        public ActionResult<List<Item>> Get(string searchedPhrase)
        {
            var items = _itemsService.Get(searchedPhrase);

            if (items == null)
                return NotFound();

            return items;
        }

        [HttpGet]
        [Route("Parse")]
        public ActionResult<List<Item>> Get(string name, int page)
        {
            var items = _websiteParser.GetItems(name, page);

            if (items == null)
                return NotFound();

            return items;
        }

        [HttpPost]
        public ActionResult<Item> Create(Item item)
        {
            _itemsService.Create(item);

            return CreatedAtRoute("GetItem", new { id = item.PID.ToString() }, item);
        }

        [HttpPost]
        [Route("CreateMany")]
        public ActionResult<Item> CreateMany(List<Item> items)
        {
            _itemsService.CreateMany(items);

            return CreatedAtRoute("GetItems", new List<Item>());
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Item itemIn)
        {
            var item = _itemsService.Get(id);

            if (item == null)
            {
                return NotFound();
            }

            _itemsService.Update(id, itemIn);

            return NoContent();
        }

        [HttpPut(Name = "Upsert")]
        public IActionResult Upsert(int id, Item itemIn)
        {
            _itemsService.Upsert(id, itemIn);

            return NoContent();
        }

        [HttpPut]
        [Route("UpsertItems")]
        public IActionResult Upsert(List<Item> itemsIn)
        {
            _itemsService.Upsert(itemsIn);
        
            return NoContent();
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _itemsService.Get(id);

            if (item == null)
            {
                return NotFound();
            }

            _itemsService.Remove(item.PID);

            return NoContent();
        }





    }
}
