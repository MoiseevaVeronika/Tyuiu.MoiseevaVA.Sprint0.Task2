using Tyuiu.MoiseevaVA.Sprint0.Task3.V0.Lib1;
namespace Tyuiu.MoiseevaVA.Sprint0.Task3.V0.Test1
{
    [TestClass]
    public sealed class DataServiceTest1
    {
        [TestMethod]
        public void CheckedVoid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
