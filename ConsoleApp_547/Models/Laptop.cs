namespace ConsoleApp_547.Models;

internal class Laptop
{
    private static int id = 1;

    public int Id { get; set; }
    

    public string Model { get; set; }

    public string Description { get; set; }

    public int Ram { get; set; }

    public decimal Price { get; set; }
    public string GraphicsCard { get; set; }        
    public double ScreenSize { get; set; }           
    public bool HasMechanicalKeyboard { get; set; }    
    public int BatteryLife { get; set; }

    public Laptop() { this.Id = id++; }

    public Laptop(string model, string description, int ram, decimal price,string graphicsCard, double screenSize, bool hasMechanicalKeyboard, int batteryLifeHours)
    {
        this.Id = id++;
        this.Model = model;
        this.Description = description;
        this.Ram = ram;
        this.Price = price;

        
        this.GraphicsCard = graphicsCard;
        this.ScreenSize = screenSize;
        this.HasMechanicalKeyboard = hasMechanicalKeyboard;
        this.BatteryLife = batteryLifeHours;
    }
}
