using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExercises.Core.Enums
{
    public enum OrderStatus
    {
        /// <summary>
        /// Sipariş oluşturuldu, ancak işleme alınmadı.
        /// </summary>
        Pending = 0,

        /// <summary>
        /// Sipariş başarıyla tamamlandı.
        /// </summary>
        Completed = 1,

        /// <summary>
        /// Sipariş iptal edildi.
        /// </summary>
        Cancelled = 2,

        /// <summary>
        /// Sipariş iade edildi ve para iadesi yapıldı.
        /// </summary>
        Refunded = 3,

        /// <summary>
        /// Sipariş kargoya verildi.
        /// </summary>
        Shipped = 4,

        /// <summary>
        /// Sipariş teslim edildi.
        /// </summary>
        Delivered = 5,
    }

}
