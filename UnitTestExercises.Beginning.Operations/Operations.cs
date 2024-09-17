using UnitTestExercises.Beginning.Models;

namespace UnitTestExercises.Beginning.Operations
{
    public class Operations
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

                if(item.Price<0)
                    throw new ArgumentException("Price cannot be negative!");

                total += item.Price*item.Quantity;
            }
            return total;
        }
        #endregion
        #region Oyun Kayıt, gameName boş değil, price 0 dan küçük değil
        public bool CreateGame(string gameName, decimal price)
        {
            if (string.IsNullOrEmpty(gameName))
                return false;

            if (price <= 0)
                return false;

            return true;
        }
        #endregion
        #region Müşteri İndirim Uygunluğu, Toplam Satın Alma 500 üzeri ise True Değil ise False
        public bool IsEligibleForDiscount(decimal totalPurchase)
        {
            if (totalPurchase >= 500)
                return true;
            else
                return false;
        }
        #endregion
        #region Kullanıcı Kayıt İşlemi, Kullanıcı adı uygun (not empty not null), parola en az 6 karakter ise True Değil ise False

        public bool ValidateUserRegistration(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                return false;

            if (password.Length < 6)
                return false;

            return true;
        }
        #endregion
    }

   

}