using Regex_Day20_222Batch;

namespace RegexTestProject
{
    [TestClass]
    public class UnitTest1
    {   ///Arrange           
        [TestMethod]
        [DataRow("91 9876543210")]//test input 01
        [DataRow("91-9876543210")]//test input 02 
        public void TestMethod1(string inputMobile)
        {
            //if min 3 characters  test will pass
            ///Act
            bool result = RegexValidateCheck.RegexValidate(inputMobile);
            ///Assert
            Assert.AreEqual(true, result);
        }
    }
}