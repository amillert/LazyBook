﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(LazyBook.MockDataStore))]
namespace LazyBook
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString() , Name = "Ksiazka", Author = "Marcin", Publisher = "Bartek", Year = "2017", Category = Models.Helper.Categories[1] , Summary = "Zajebista ksiazka!!!111one" },
                new Item { Id = Guid.NewGuid().ToString() , Name = "Ksiazka", Author = "Marcin", Publisher = "Bartek", Year = "2017", Category = Models.Helper.Categories[1] , Summary = "Zajebista ksiazka!!!111one" },
                new Item { Id = Guid.NewGuid().ToString() , Name = "Ksiazka", Author = "Marcin", Publisher = "Bartek", Year = "2017", Category = Models.Helper.Categories[1] , Summary = "Zajebista ksiazka!!!111one" },
                new Item { Id = Guid.NewGuid().ToString() , Name = "Ksiazka", Author = "Marcin", Publisher = "Bartek", Year = "2017", Category = Models.Helper.Categories[1] , Summary = "Zajebista ksiazka!!!111one" },
                new Item { Id = Guid.NewGuid().ToString() , Name = "Ksiazka", Author = "Marcin", Publisher = "Bartek", Year = "2017", Category = Models.Helper.Categories[1] , Summary = "Zajebista ksiazka!!!111one" },
                new Item { Id = Guid.NewGuid().ToString() , Name = "Ksiazka", Author = "Marcin", Publisher = "Bartek", Year = "2017", Category = Models.Helper.Categories[1] , Summary = "Zajebista ksiazka!!!111one" },
                new Item { Id = Guid.NewGuid().ToString() , Name = "Ksiazka", Author = "Marcin", Publisher = "Bartek", Year = "2017", Category = Models.Helper.Categories[1] , Summary = "Zajebista ksiazka!!!111one" },
                new Item { Id = Guid.NewGuid().ToString() , Name = "Ksiazka", Author = "Marcin", Publisher = "Bartek", Year = "2017", Category = Models.Helper.Categories[1] , Summary = "Zajebista ksiazka!!!111one" },
                new Item { Id = Guid.NewGuid().ToString() , Name = "Ksiazka", Author = "Marcin", Publisher = "Bartek", Year = "2017", Category = Models.Helper.Categories[1] , Summary = "Zajebista ksiazka!!!111one" }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
