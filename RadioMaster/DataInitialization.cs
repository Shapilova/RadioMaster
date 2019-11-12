using RadioMaster.Models;

namespace RadioMaster
{
    public class DataInitialization
    {
        public static void initializeCatalog()
        {
            ItemType itemType1 = new ItemType(1, "резисторы");
            ItemType itemType2 = new ItemType(2, "тиристоры");
            ItemType itemType3 = new ItemType(3, "диоды");

            CatalogRep.AddItemType(itemType1);
            CatalogRep.AddItemType(itemType2);
            CatalogRep.AddItemType(itemType3);

            CatalogRep.AddItem(new Item(1, "testItem1", 100, 1, itemType1));
            CatalogRep.AddItem(new Item(2, "testItem2", 200, 2, itemType2));
            CatalogRep.AddItem(new Item(3, "3testItem3", 300, 2, itemType2));
            CatalogRep.AddItem(new Item(4, "4testItem4", 400, 3, itemType3));
        }
    }
}
