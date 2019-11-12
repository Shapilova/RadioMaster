namespace RadioMaster.Models
{
    public class ItemType
    {
        public int Id { get; set; }         //Ключ категории товара
        public string Name { get; set; }    //Наименование категории товара
        public byte Photo { get; set; }     //Фото категории товара

        public ItemType(int id, string name, byte photo)
        {
            Id = id;
            Name = name;
            Photo = photo;
        }
        public ItemType(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
