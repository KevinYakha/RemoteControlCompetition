using System;
using System.Collections.Generic;

public interface IRemoteControlCar
{
    public void Drive();

    public int DistanceTravelled { get; set; }
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; set; }
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

    int IComparable<ProductionRemoteControlCar>.CompareTo(ProductionRemoteControlCar other)
    {
        return NumberOfVictories - other.NumberOfVictories;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        List<ProductionRemoteControlCar> sorted = [prc1, prc2];
        sorted.Sort();
        return sorted;
    }
}
