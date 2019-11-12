namespace RadioMaster.Models
{
    public class Item
    {
        public int Id { get; set; }             //Ключ товара
        public string Name { get; set; }        //Наименование товара
        public int Price { get; set; }          //Цена товара
        public int ItemTypeId { get; set; }     //Ключ типа товара
        public ItemType ItemType { get; set; }  //Тип товара

        public Item(int id, string name, int price, int itemTypeId, ItemType itemType)
        {
            Id = id;
            Name = name;
            Price = price;
            ItemTypeId = itemTypeId;
            ItemType = itemType;
        }
    }
}
