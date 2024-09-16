using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExercises.Beginning.Operations.Tests
{
    public class OperationTests
    {
        Operations operations = new Operations();
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
    }
}
