using System.Collections.Generic;
using System.Linq;

namespace RadioMaster.Models
{
    public class CatalogRep
    {
        private static List<Item> catalog = new List<Item>();
        private static List<ItemType> categories = new List<ItemType>();

        public static IEnumerable<Item> Сatalog
        {
            get
            {
                return catalog;
            }
        }
        public static IEnumerable<ItemType> Categories
        {
            get
            {
                return categories;
            }
        }

        public static void AddItemType(ItemType itemType)
        {
            categories.Add(itemType);
        }

        public static void AddItem(Item item)
        {
            catalog.Add(item);
        }

        public static void RemoveItem(Item removeItem)
        {
            Item item = catalog
                .Where(x => x.Id == removeItem.Id)
                .FirstOrDefault();

            if (item != null)
            {
                catalog.Remove(item);
            }
        }

        public static void RemoveItemType(ItemType removeItemType)
        {
            ItemType itemType = categories
                .Where(x => x.Id == removeItemType.Id)
                .FirstOrDefault();

            if (itemType != null)
            {
                categories.Remove(itemType);
            }
        }
    }
}
