using System.Collections.Generic;
using System.Linq;

namespace RadioMaster.Models
{
    //Репозиторий корзины
    public class CartRep
    {
        private static List<CartLine> cart = new List<CartLine>(); //Корзина
        public static IEnumerable<CartLine> Cart //Перечисление позиций корзины 
        {
            get
            {
                return cart;
            }
        }

        //Добавить товар
        public static void AddItem(Item item)
        {
            CartLine line = cart
                .Where(x => x.Item.Id == item.Id)
                .FirstOrDefault();

            if (line == null)
            {
                cart.Add(new CartLine
                {
                    Item = item,
                    Count = 1
                });
            }
            else
            {
                line.Count += 1;
            }
        }

        //Удалить товар
        public static void RemoveItem(Item item)
        {
            CartLine line = cart
                .Where(x => x.Item.Id == item.Id)
                .FirstOrDefault();

            if (line != null)
            {
                line.Count -= 1;
            }
        }

        //Удалить позицию
        public static void RemoveLine(Item item)
        {
            cart.RemoveAll(x => x.Item.Id == item.Id);
        }

        //Рассчитать сумму позиции
        public static decimal LinesSum()
        {
            return cart.Sum(x => x.Item.Price * x.Count);

        }

        //Очистить корзину
        public static void Clear()
        {
            cart.Clear();
        }
    }
}
