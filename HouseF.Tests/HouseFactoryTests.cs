using NUnit.Framework;
using System;
using System.Reflection;
using System.Text;

namespace HouseF.Tests
{
    [TestFixture]
    public class HouseFactoryTests
    {
        //Testing private method with Reflection
        [TestCase("onestoreyhouse")]
        public void GetHouseFromDictionary_Get_Should_Return_The_House_Type_OneStoreyHouse(string houseName)
        {
            //Arrange
            MethodInfo method = typeof(HouseFactory)
                .GetMethod("GetHouseFromDictionary", BindingFlags.NonPublic | BindingFlags.Instance);

            if(method == null) Assert.Fail("Could not find private method GetHouseFromDictionary");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"This house is located at Mästaregatan 2B.");
            sb.AppendLine($"It has 3 rooms and 20 windows");
            sb.AppendLine($"It has a garage with place for 1 cars");

            string expectedOutput = sb.ToString();

            //Act
            object calculatedObject = method!.Invoke(new HouseFactory(), new object[] { houseName });
            string calculatedResult = calculatedObject.ToString();

           Assert.That(calculatedResult, Is.EqualTo(expectedOutput));
        }
    }
}