using System;
using System.Collections.Generic;
using System.Text;

namespace BasicShop.Entity
{
    public class Cart
    {
        public Cart()
        {
            CartItems=new List<CartItem>();
        }
        public List<CartItem> CartItems { get; set; }
    }

    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
