using Sklep_Internetowy_JW.Models;

namespace Sklep_Internetowy_JW.Infrastructure
{
    public class CartItem
    {
        public Film Film { get; set; }

        public int Quantity { get; set; }

        public decimal? Value { get; set; }
    }
}
