using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealer.Models;

namespace CarDealer.TestTools
{
  [TestClass]
  public class CarTests : IDisposable
  {

    public void Dispose()
    {
      Car.ClearAll();
    }

    [TestMethod]
    public void CarConstructor_CreateInstanceOfCar_Type()
    {
        Car newCar = new Car("test", 1, 1);
        Assert.AreEqual(typeof(Car), newCar.GetType());
    }

    [TestMethod]
    public void CarContructor_ReturnsMakeModel_String()
    {
      string model = "crown vic";
      Car newCar = new Car(model, 1, 1);
      Assert.AreEqual(model, newCar.MakeModel);
    }

      [TestMethod]
    public void CarContructor_SetsMakeModel_String()
    {
      string model = "crown vic";
      Car newCar = new Car(model, 1, 1);
      string updateModel = "escort";
      newCar.MakeModel = updateModel;
      Assert.AreEqual(updateModel, newCar.MakeModel);
    }

    [TestMethod]
    public void GetLot_ReturnsAnEmptyList_List()
    {
      List<Car> list = new List<Car>{};
      List<Car> newList = Car.GetLot();
      CollectionAssert.AreEqual(list, newList);
    }

    [TestMethod]
    public void GetLot_ReturnsCarList_List()
    {
      string ford = "ford";
      string lexus = "lexus";
      Car carOne = new Car(ford, 1, 1);
      Car carTwo = new Car(lexus, 1, 1);
      List<Car> lotList = Car.GetLot();
      List<Car> lotListTwo = new List<Car> { carOne, carTwo };
      CollectionAssert.AreEqual(lotListTwo, lotList);
    }
  }
}