using Regex_Day20_222Batch;

namespace RegexTestProject
{
    [TestClass]
    public class UnitTest1
    {   ///Arrange           
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in")]//test input 
        [DataRow("abc@bl.co")]//test input 
        public void TestMethod1(string inputemail)
        {
            //if min 3 characters  test will pass
            ///Act
            bool result = RegexValidateCheck.RegexValidate(inputemail);
            ///Assert
            Assert.AreEqual(true, result);
        }
    }
}