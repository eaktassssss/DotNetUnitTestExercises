using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExercises.Beginning.Operations.Operations
{
    public  class DiscountOperations
    {
        #region Müşteri İndirim Uygunluğu, Toplam Satın Alma 500 üzeri ise True Değil ise False
        public bool IsEligibleForDiscount(decimal totalPurchase)
        {
            if (totalPurchase >= 500)
                return true;
            else
                return false;
        }
        #endregion
    }
}
