using UnitTestExercises.Beginning.Builders.OperationTestDataBuilders;
using UnitTestExercises.Beginning.Models;
using UnitTestExercises.Beginning.Operations.Operations;

namespace UnitTestExercises.Beginning.Operations.Tests.Tests.OperationTests
{
    public class OrderOperationTests
    {
        private OrderOperations orderOperations = new OrderOperations();
        private OrderItemTestDataBuilder dataBuilder = new OrderItemTestDataBuilder();

        #region Order Tests

        [Theory]
        [InlineData(24)]
        public void CanProcessOrder_ValidOrder_ReturnsTrue(decimal minimumOrderAmount)
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

            var result = orderOperations.CanProcessOrder(orderItems, minimumOrderAmount);

            Assert.True(result);
        }

        [Theory]
        [InlineData(30)]
        public void CanProcessOrder_TotalBelowMinimum_ReturnsFalse(decimal minimumOrderAmount)
        {
            var orderItems = dataBuilder.OrderOperation_CanProcessOrder();

            var result = orderOperations.CanProcessOrder(orderItems, minimumOrderAmount);

            Assert.False(result);
        }

        [Theory]
        [InlineData(30)]
        public void CanProcessOrder_QuantityExceedsStock_ReturnsFalse(decimal minimumOrderAmount)
        {
            var orderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Price = 400,
                    Quantity =10,
                    StockAvailable=9,
                },
                new OrderItem
                {
                    Price = 300,
                    Quantity =7,
                    StockAvailable=10,
                },
                new OrderItem
                {
                    Price = 200,
                    Quantity =8,
                    StockAvailable=10,
                }
            };

            var result = orderOperations.CanProcessOrder(orderItems, minimumOrderAmount);

            Assert.False(result);
        }

        [Theory]
        [InlineData(-1)]
        public void CanProcessOrder_NegativeMinimumOrderAmount_ReturnsFalse(decimal minimumOrderAmount)
        {
            var orderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Price = 400,
                    Quantity =10,
                    StockAvailable=9,
                },
                new OrderItem
                {
                    Price = 300,
                    Quantity =7,
                    StockAvailable=10,
                },
                new OrderItem
                {
                    Price = 200,
                    Quantity =8,
                    StockAvailable=10,
                }
            };

            var result = orderOperations.CanProcessOrder(orderItems, minimumOrderAmount);

            Assert.False(result);
        }

        [Theory]
        [InlineData(20)]
        public void CanProcessOrder_NullOrderItems_ReturnsFalse(decimal minimumOrderAmount)
        {
            List<OrderItem>? orderItems = null;

            var result = orderOperations.CanProcessOrder(orderItems, minimumOrderAmount);

            Assert.False(result);
        }

        [Theory]
        [InlineData(20)]
        public void CanProcessOrder_NegativePrice_ReturnsFalse(decimal minimumOrderAmount)
        {
            var orderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Price = 400,
                    Quantity =10,
                    StockAvailable=9,
                },
                new OrderItem
                {
                    Price = 300,
                    Quantity =7,
                    StockAvailable=10,
                },
                new OrderItem
                {
                    Price = -1,
                    Quantity =8,
                    StockAvailable=10,
                }
            };

            var result = orderOperations.CanProcessOrder(orderItems, minimumOrderAmount);
            Assert.False(result);
        }

        [Theory]
        [InlineData(20)]
        public void CanProcessOrder_NegativeQuantity_ReturnsFalse(decimal minimumOrderAmount)
        {
            var orderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Price = 400,
                    Quantity =10,
                    StockAvailable=9,
                },
                new OrderItem
                {
                    Price = 300,
                    Quantity =-1,
                    StockAvailable=10,
                },
                new OrderItem
                {
                    Price = 200,
                    Quantity =8,
                    StockAvailable=10,
                }
            };

            var result = orderOperations.CanProcessOrder(orderItems, minimumOrderAmount);
            Assert.False(result);
        }

        #endregion Order Tests
    }
}