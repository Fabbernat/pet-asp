namespace PetAsp.Models;
public class Pet
{
    public Pet() { }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Nem { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public string PhotoUrl { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
}
