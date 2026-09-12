using Tyuiu.ShalaevaVV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ShalaevaVV.Sprint0.Task2.V0.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CheckGetMessageValid()
    {
        // Область создания методов тестирования, методов из библиотеки
        var name = "Влада";
        var res = DataService.GetMessage(name);
        // Вызываем класс Assert и метод AreEgual
        Assert.AreEqual("Привет, Влада", res);
        Assert.Pass();
    }
}