using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Beginning.Models;

namespace UnitTestExercises.Beginning.Operations.Operations
{
    public  class OrderOperations
    {
        #region Siparişin toplam tutarını hesaplama. Siparişler bir fiyat ve adet içerir. Toplam sipariş tutarı, her ürünün fiyatı ile miktarının çarpımından elde edilir.
        public decimal CalculateOrderTotal(List<OrderItem> orderItems)
        {
            decimal total = 0;

            if (orderItems == null)
                return 0;

            foreach (var item in orderItems)
            {
                if (item.Quantity < 0)
                    throw new ArgumentException("Quantity cannot be negative!");

                if (item.Price < 0)
                    throw new ArgumentException("Price cannot be negative!");

                total += item.Price * item.Quantity;
            }
            return total;
        }
        #endregion
        #region Bir siparişin işlenip işlenemeyeceğini kontrol eder. Eğer ürünler stokta varsa ve sipariş toplamı belirli bir miktarın altındaysa, işlenemez
        public bool CanProcessOrder(List<OrderItem> items, decimal minimumOrderAmount)
        {
            if (minimumOrderAmount < 0)
                return false;

            if (items == null || !items.Any())
                return false;

       
            foreach (var item in items)
            {
                if (item.Quantity < 0 || item.Price < 0)
                    return false; 

                if (item.Quantity > item.StockAvailable)
                    return false;
            }

            var total = CalculateOrderTotal(items); 

            if (total < minimumOrderAmount)
                return false; 

            return true;
        }

        #endregion
    }
}
