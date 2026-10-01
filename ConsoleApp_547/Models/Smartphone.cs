namespace ConsoleApp_547.Models;

internal class Smartphone
{
    private static int id = 1;

    public int Id { get; set; }

    public string Model { get; set; }

    public string Description { get; set; }

    public int Ram { get; set; }

    public decimal Price { get; set; }

    public int CameraMegapixels { get; set; }      
    public int BatteryLife { get; set; }        
    public int SimSlots { get; set; }          
    public bool Supports5G { get; set; }

    public Smartphone() { this.Id = id++; }

    public Smartphone(string model, string description, int ram, decimal price,
                      int cameraMegapixels, int batteryLife, int simSlots, bool supports5G)
    {
        this.Id = id++;
        this.Model = model;
        this.Description = description;
        this.Ram = ram;
        this.Price = price;

        
        this.CameraMegapixels = cameraMegapixels;
        this.BatteryLife = batteryLife;
        this.SimSlots = simSlots;
        this.Supports5G = supports5G;
    }
}
