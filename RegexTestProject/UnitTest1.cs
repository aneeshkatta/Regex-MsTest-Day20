using Regex_Day20_222Batch;

namespace RegexTestProject
{
    [TestClass]
    public class UnitTest1
    {   ///Arrange           
        [TestMethod]
        [DataRow("PassWorD@123")]//test input 01
        [DataRow("Password#123")]//test input 02
        public void TestMethod1(string Password)
        {
            ///Act
            bool result = RegexValidateCheck.RegexValidate(Password);
            ///Assert
            Assert.AreEqual(true, result);
        }
    }
}
