public class Car : IVehicle
{
    int _amount;
    public Car(int amount){
        _amount = amount;
    }
    public void Drive()
    {
        if (_amount >0)
        {System.Console.WriteLine("Driving");}
    }
    public bool Refuel(int amount)
    {
        _amount = _amount + amount;
        return true;
    }
}