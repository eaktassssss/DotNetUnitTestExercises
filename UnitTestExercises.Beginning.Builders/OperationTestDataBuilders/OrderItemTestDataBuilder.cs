using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Beginning.Models;

namespace UnitTestExercises.Beginning.Builders.OperationTestDataBuilders
{
    public class OrderItemTestDataBuilder
    {
        public  List<OrderItem> OrderOperation_CalculateOrderTotal_SingleItemOrder()
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
        public  List<OrderItem> OrderOperation_CalculateOrderTotal_MultipleItemsOrder()
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
        public List<OrderItem> OrderOperation_CanProcessOrder()
        {
            var orderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Price = 1,
                    Quantity =10,
                    StockAvailable=11,
                },
                new OrderItem
                {
                    Price = 1,
                    Quantity =7,
                    StockAvailable=8,
                },
                new OrderItem
                {
                    Price = 1,
                    Quantity =8,
                    StockAvailable=9,
                }
            };
            return orderItems;

        }
    }
}
