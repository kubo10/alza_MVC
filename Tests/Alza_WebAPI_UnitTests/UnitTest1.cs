using Alza_WebAPI_Database;
using Alza_WebAPI_InMemoryDatabase;

namespace Alza_WebAPI_UnitTests
{
    [TestClass]
    public class UnitTest1 : InMemoryTestDatabase
    {
        [TestInitialize] 
        public async Task Init()
        {
        }

        [TestMethod]
        public void TestMethod1() 
        {
        }
    }
}