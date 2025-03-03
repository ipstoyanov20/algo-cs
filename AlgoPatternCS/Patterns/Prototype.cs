namespace AlgoPatternCS.Patterns;

public class  Engine
{
    public int HorsePower { get; set; }
    public string Name { get; set; }
    
}

public interface IPrototype
{
    IPrototype Clone();
}

public class CarPrototype : IPrototype
{
    public int Kilometer { get; set; }
    public int Price { get; set; }
    public Engine Engine { get; set; }

    public CarPrototype()
    {
        
    }

    public void Run()
    {
        CarPrototype originalCar = new CarPrototype()
        {
            Kilometer = 10000,
            Price = 20000,
            Engine = new Engine
            {
                HorsePower = 150,
                Name = "V8"
            }
        };

        // Clone the original car
        CarPrototype clonedCar = (CarPrototype)originalCar.Clone();

        clonedCar.Engine.HorsePower = 12;

        // Display original and cloned car details
        Console.WriteLine($"Original Car: {originalCar.Kilometer} km, {originalCar.Price} USD, Engine: {originalCar.Engine.Name} {originalCar.Engine.HorsePower} HP");
        Console.WriteLine($"Cloned Car: {clonedCar.Kilometer} km, {clonedCar.Price} USD, Engine: {clonedCar.Engine.Name} {clonedCar.Engine.HorsePower} HP");
    }
    
    public CarPrototype(CarPrototype other)
    {
        this.Engine = other.Engine;
        this.Price = other.Price;
        this.Kilometer = other.Kilometer;
    }
    public IPrototype Clone()
    {
        return new CarPrototype
        {
            Engine = new Engine
            {
                HorsePower = Engine.HorsePower,
                Name = Engine.Name
            },
            Kilometer = Kilometer,
            Price = Price
            
        };
    }
}