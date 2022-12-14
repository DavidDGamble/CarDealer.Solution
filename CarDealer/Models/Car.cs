namespace CarDealer.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public string Price { get; set; }
    public string Miles { get; set; }
    private static List<Car> _lot = new List<Car> { };

    public Car(string makeModel, string price, string miles)
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

    public static void RemoveCar(string car)
    {
      int index = -1;
      for(int i = 0; i < _lot.Count; i++)
      {
        if(_lot[i].MakeModel == car)
        {
          index = i;
          break;
        }
      }
        _lot.RemoveAt(index);
    }
  }
}
