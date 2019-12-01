namespace RadioMaster.Models
{
    //Позиция в корзине
    public class CartLine
    {
        public Item Item { get; set; } //Товар
        public int Count { get; set; } //Количество
    }
}
