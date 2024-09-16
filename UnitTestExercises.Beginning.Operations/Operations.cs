namespace UnitTestExercises.Beginning.Operations
{
    public class Operations
    {
        #region Oyun Kayıt, gameName boş değil, price 0 dan küçük değil,
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