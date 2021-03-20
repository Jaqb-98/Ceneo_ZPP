using Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    /// <summary>
    /// Provides operations on batabase
    /// </summary>
    public interface IItemsService
    {
        /// <summary>
        /// Returns all items from collection
        /// </summary>
        /// <returns></returns>
        List<Item> Get();


        /// <summary>
        /// Returns item with id specified in parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Item Get(int id);

        /// <summary>
        /// Returns all items form collection that has searchedPhrase in Name or Category
        /// </summary>
        /// <param name="searchedPhrase"></param>
        /// <returns></returns>
        List<Item> Get(string searchedPhrase);


        /// <summary>
        /// Puts new item into collection
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Item Create(Item item);


        /// <summary>
        /// Puts list of items into collection
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        List<Item> CreateMany(List<Item> items);


        /// <summary>
        /// Finds item with id form parameters and replaces it with ItemIn
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ItemIn"></param>
        void Update(int id, Item ItemIn);


        /// <summary>
        /// Removes ItemIn from collection
        /// </summary>
        /// <param name="ItemIn"></param>
        void Remove(Item ItemIn);


        /// <summary>
        /// Removes item with matching id
        /// </summary>
        /// <param name="id"></param>
        void Remove(int id);


        /// <summary>
        /// Replaces item with matching id with ItemIn. If item with id from parameters doesn't exist, creates new item ItemIn
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ItemIn"></param>
        void Upsert(int id, Item ItemIn);


        /// <summary>
        /// Performs upsert operation on List of Items
        /// </summary>
        /// <param name="items"></param>
        void Upsert(List<Item> items);

    }
}
