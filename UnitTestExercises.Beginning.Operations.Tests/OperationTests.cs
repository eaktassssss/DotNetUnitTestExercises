using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Beginning.Models;
using UnitTestExercises.Beginning.Operations.Tests.FakeDataGenerater;

namespace UnitTestExercises.Beginning.Operations.Tests
{
    public class OperationTests
    {
        Operations operations = new Operations();
        #region MyRegion
        [Theory]
        [InlineData("Counter-Strike Global Offensive", 1500)]
        [InlineData("Grand Theft Auto 5 (GTA 5)", 1)]
        [InlineData("Minecraft", 100)]
        public void Operations_CreateGame_Success(string gameName, decimal price)
        {
            var result = operations.CreateGame(gameName, price);
            Assert.True(result);
        }

        [Fact]
        public void Operations_CreateGame_NotValidGameName()
        {
            string gameName = "";
            decimal price = 1500;
            var result = operations.CreateGame(gameName, price);
            Assert.False(result);
        }

        [Fact]
        public void Operations_CreateGame_NotValidPrice()
        {
            string gameName = "Call Of Duty";
            decimal price = -1;
            var result = operations.CreateGame(gameName, price);
            Assert.False(result);
        }

        #endregion
        #region IsEligibleForDiscount
        [Theory]
        [InlineData(499)]
        public void Operation_IsEligible_TotalPurchase_LessThan500_ReturnsFalse(decimal totalPurchase)
        {
            var result = operations.IsEligibleForDiscount(totalPurchase);
            Assert.False(result);
        }
       
        [Theory]
        [InlineData(500)]
        [InlineData(501)]
        public void Operation_IsEligible_TotalPurchase_GreaterThan500_ResturnsTrue(decimal totalPurchase)
        {
            var result = operations.IsEligibleForDiscount(totalPurchase);
            Assert.True(result);
        }
        #endregion
        #region Validate User Registration Test
        [Theory]
        [InlineData(null, "123aBc")]
        [InlineData("", "123aBc")]
        public void Operation_ValidateUserRegistration_UserName_NullOrEmpty_ReturnsFalse(string userName, string password)
        {
            var result = operations.ValidateUserRegistration(userName, password);
            Assert.False(result);
        }

        [Theory]
        [InlineData("eaktas", "123aB")]
        public void Operation_ValidateUserRegistration_Password_LessThan6Characters_ReturnsFalse(string userName, string password)
        {
            var result = operations.ValidateUserRegistration(userName, password);
            Assert.False(result);
        }

        [Theory]
        [InlineData("eaktas", "123aBc")]
        public void Operation_ValidateUserRegistration_ValidUserNamePassword_ReturnsTrue(string userName, string password)
        {
            var result = operations.ValidateUserRegistration(userName, password);
            Assert.True(result);
        }
        #endregion
        #region Order Tests
        [Fact]
        public void Operation_CalculateOrderTotal_SingleItemOrder_Success()
        {
            var expected = 500;
            var items = DataGenerater.SingleItemOrder();

            var result = operations.CalculateOrderTotal(items);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Operation_CalculateOrderTotal_MultipleItemOrder_Success()
        {
            var expected = 1500;
            var items = DataGenerater.MultipleItemsOrder();

            var result = operations.CalculateOrderTotal(items);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Operation_CalculateOrderTotal_EmptyOrderItem_ReturnsZero()
        {
            var orderItems = DataGenerater.EmptyOrderItems();

            var result = operations.CalculateOrderTotal(orderItems);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Operation_CalculateOrderTotal_NullOrderItem_ReturnsZero()
        {
            var orderItems = (List<OrderItem>)null;

            var result = operations.CalculateOrderTotal(orderItems);

            Assert.Equal(0, result);
        }


        [Fact]
        public void Operation_CalculateOrderTotal_NegativeQuantity_ThrowsArgumentException()
        {
            var items = new List<OrderItem>
            {
                new OrderItem{Price=1500,Quantity=-1}
            };
            Assert.Throws<ArgumentException>(() => operations.CalculateOrderTotal(items));
        }


        [Fact]
        public void Operation_CalculateOrderTotal_NegativePrice_ThrowsArgumentException()
        {
            var items = new List<OrderItem>
            {
                new OrderItem{Price=-1,Quantity=4}
            };
            Assert.Throws<ArgumentException>(() => operations.CalculateOrderTotal(items));
        }

        [Fact]
        public void Operation_CalculateOrderTotal_ZeroQuantity_SkipsItem()
        {
            var items = new List<OrderItem>
             {
                 new OrderItem { Price = 100, Quantity = 0 },
                 new OrderItem { Price = 50, Quantity = 2 }
             };

            var result  = operations.CalculateOrderTotal(items);
            Assert.Equal(100, result);

        }

        [Fact]
        public void Operation_CalculateOrderTotal_MaxIntQuantity_DoesNotOverflow()
        {
            decimal expected = (decimal)100 * int.MaxValue;

            var items = new List<OrderItem>
             {
                 new OrderItem { Price = 100, Quantity = int.MaxValue }
             };

            var result = operations.CalculateOrderTotal(items);
            Assert.Equal(expected, result);

        }
        #endregion
    }
}
