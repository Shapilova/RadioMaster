using System.Collections.Generic;
using System.Linq;

namespace RadioMaster.Models
{
    public class CartRep
    {
        private static List<CartLine> cart = new List<CartLine>();
        public static IEnumerable<CartLine> Cart
        {
            get
            {
                return cart;
            }
        }

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

        public static void RemoveLine(Item item)
        {
            cart.RemoveAll(x => x.Item.Id == item.Id);
        }

        public static decimal LinesSum()
        {
            return cart.Sum(x => x.Item.Price * x.Count);

        }
        public static void Clear()
        {
            cart.Clear();
        }
    }
}
