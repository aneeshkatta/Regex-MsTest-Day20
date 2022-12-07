using Regex_Day20_222Batch;

namespace RegexTestProject
{
    [TestClass]
    public class UnitTest1
    {   ///Arrange           
        [TestMethod]
        [DataRow("Ravi@123#%")]//test input 01
        [DataRow("Ken")]//test input 02
        [DataRow("raJ")]//test input 03   
        public void TestMethod1(string inputLastName)
        {
            //if min 3 characters  test will pass
            ///Act
            bool result = RegexValidateCheck.RegexValidate(inputLastName);
            ///Assert
            Assert.AreEqual(true, result);
        }
    }
}