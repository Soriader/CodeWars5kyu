namespace CodeWars5kyu;

public interface ICar
{
    bool EngineIsRunning { get; }

    void EngineStart();

    void EngineStop();

    void Refuel(double liters);

    void RunningIdle();
}

public interface IEngine
{
    bool IsRunning { get; }

    void Consume(double liters);

    void Start();

    void Stop();
}

public interface IFuelTank
{
    double FillLevel { get; }

    bool IsOnReserve { get; }

    bool IsComplete { get; }

    void Consume(double liters);

    void Refuel(double liters);        
}

public interface IFuelTankDisplay
{
    double FillLevel { get; }

    bool IsOnReserve { get; }

    bool IsComplete { get; }
}
public class Car : ICar
{
    public IFuelTankDisplay fuelTankDisplay { get; private set; }
    private IEngine engine;
    private IFuelTank fuelTank;

    public bool EngineIsRunning => engine.IsRunning;

    public Car() : this(20) { }

    public Car(double fuelLevel)
    {
        fuelTank = new FuelTank(fuelLevel);
        fuelTankDisplay = new FuelTankDisplay(fuelTank);
        engine = new Engine(fuelTank);
    }

    public void EngineStart()
    {
        engine.Start();
    }

    public void EngineStop()
    {
        engine.Stop();
    }

    public void Refuel(double liters)
    {
        fuelTank.Refuel(liters);
    }

    public void RunningIdle()
    {
        engine.Consume(0.0003);
    }
}

public class Engine : IEngine
{
    private IFuelTank fuelTank;
    public bool IsRunning { get; private set; }

    public Engine(IFuelTank fuelTank)
    {
        this.fuelTank = fuelTank;
    }

    public void Start()
    {
        if (fuelTank.FillLevel > 0)
            IsRunning = true;
    }

    public void Stop()
    {
        IsRunning = false;
    }

    public void Consume(double liters)
    {
        if (IsRunning)
        {
            fuelTank.Consume(liters);
            if (fuelTank.FillLevel == 0)
                Stop();
        }
    }
}

public class FuelTank : IFuelTank
{
    private double fillLevel;
    public double FillLevel => Math.Round(fillLevel, 10);
    public bool IsOnReserve => fillLevel < 5;
    public bool IsComplete => fillLevel == 60;

    public FuelTank(double initialLevel)
    {
        fillLevel = Math.Max(0, Math.Min(initialLevel, 60));
    }

    public void Consume(double liters)
    {
        fillLevel = Math.Max(0, fillLevel - liters);
    }

    public void Refuel(double liters)
    {
        fillLevel = Math.Min(60, fillLevel + liters);
    }
}

public class FuelTankDisplay : IFuelTankDisplay
{
    private IFuelTank fuelTank;
    public double FillLevel => Math.Round(fuelTank.FillLevel, 2);
    public bool IsOnReserve => fuelTank.IsOnReserve;
    public bool IsComplete => fuelTank.IsComplete;

    public FuelTankDisplay(IFuelTank fuelTank)
    {
        this.fuelTank = fuelTank;
    }
}
//https://www.codewars.com/kata/578b4f9b7c77f535fc00002f/train/csharp