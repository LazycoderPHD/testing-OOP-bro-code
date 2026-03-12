public class Vehicle
{
    public string model;
    public string color;

    public Vehicle(string model, string color)
    {
        this.model = model;
        this.color = color;
    }

    public void drive()
    {
        Console.WriteLine($"You draw the {this.color} {this.model}");
    }
}
