//using Catalog.Entities;

//namespace Catalog.Repositories
//{
//    public class InMemItemsRepository : IItemsRepository
//    {
//        private readonly List<Item> items = new()
//        {
//            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
//            new Item { Id = Guid.NewGuid(), Name = "Iron sword", Price = 29, CreatedDate = DateTimeOffset.UtcNow },
//            new Item { Id = Guid.NewGuid(), Name = "Gold shield", Price = 49, CreatedDate = DateTimeOffset.UtcNow }
//        };

//        public IEnumerable<Item> GetItemsAsync()
//        { 
//            return items;
//        }

//        public Item GetItemAsync(Guid id)
//        {
//            return items.SingleOrDefault(item => item.Id == id);
//        }

//        public void CreateItemAsync(Item item)
//        {
//            items.Add(item);    
//        }

//        public void UpdateItemAsync(Item item)
//        {
//            var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
//            items[index] = item;
//        }

//        public void DeleteItemAsync(Guid id)
//        {
//            var index = items.FindIndex(existingItem => existingItem.Id == id);
//            items.RemoveAt(index);
//        }
//    }
//}
