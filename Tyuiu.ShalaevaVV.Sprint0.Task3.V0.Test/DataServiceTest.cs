using Tyuiu.ShalaevaVV.Sprint0.Task3.V0.Lib;
namespace Tyuiu.ShalaevaVV.Sprint0.Task3.V0.Test;

public class DataServiceTest
{
    [Test]
    public void CheckValid()
    {
        Assert.AreEqual(10, DataService.Sum(5, 5));
    }
}

   