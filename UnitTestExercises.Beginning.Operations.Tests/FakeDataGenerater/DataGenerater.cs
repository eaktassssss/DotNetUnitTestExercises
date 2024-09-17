using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Beginning.Models;

namespace UnitTestExercises.Beginning.Operations.Tests.FakeDataGenerater
{
    public static class DataGenerater
    {

        public static List<OrderItem> SingleItemOrder()
        {
            return new List<OrderItem>
            {
                new OrderItem()
                {
                    Price=100,
                    Quantity=5,
                }
            };

        }
        public static List<OrderItem> MultipleItemsOrder()
        {
            return new List<OrderItem>
            {
                new OrderItem()
                {
                    Price=100,
                    Quantity=5,
                },
                new OrderItem()
                {
                    Price=200,
                    Quantity=2

                },
                new OrderItem()
                {
                    Price=300,
                     Quantity=2,

                }
            };

        }
        public static List<OrderItem> EmptyOrderItems()
        {
            return new List<OrderItem>
            {
            };

        }
    }
}
