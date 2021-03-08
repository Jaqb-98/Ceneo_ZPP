using Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    public interface IItemsService
    {
        List<Item> Get();

        Item Get(int id);

        Item Create(Item item);

        List<Item> CreateMany(List<Item> items);

        void Update(int id, Item ItemIn);

        void Remove(Item ItemIn);

        void Remove(int id);

        void Upsert(int id, Item ItemIn);

        void Upsert(List<Item> items);

    }
}
