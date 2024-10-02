namespace UnitTestExercises.Beginning.Operations.Operations
{
    public class UserOperations
    {
        #region Kullanıcı Kayıt İşlemi, Kullanıcı adı uygun (not empty not null), parola en az 6 karakter ise True Değil ise False

        public bool ValidateUserRegistration(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                return false;

            if (password.Length < 6)
                return false;

            return true;
        }

        #endregion Kullanıcı Kayıt İşlemi, Kullanıcı adı uygun (not empty not null), parola en az 6 karakter ise True Değil ise False
    }
}