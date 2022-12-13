namespace CarDealer.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _lot = new List<Car> { };

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _lot.Add(this);
    }

    public static List<Car> GetLot()
    {
      return _lot;
    }

    public static void ClearAll()
    {
      _lot.Clear();
    }
  }
}
