using System.Collections.Generic;
using System.Linq;

namespace RadioMaster.Models
{
    //Репозиторий каталога
    public class CatalogRep
    {
        private static List<Item> catalog = new List<Item>(); //Каталог
        private static List<ItemType> categories = new List<ItemType>(); //Категории

        public static IEnumerable<Item> Сatalog //Перечисление товаров каталога
        {
            get
            {
                return catalog;
            }
        }

        public static IEnumerable<ItemType> Categories //Перечисление названий категорий
        {
            get
            {
                return categories;
            }
        }

        //Добавить тип товара
        public static void AddItemType(ItemType itemType)
        {
            categories.Add(itemType);
        }

        //Добавить товар
        public static void AddItem(Item item)
        {
            catalog.Add(item);
        }

        //Удалить тип товара
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

        //Удалить товар
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
    }
}
