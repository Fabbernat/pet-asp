namespace PetAsp.Models;

using System.Collections.Generic;


public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<Pet> Pets { get; set; } = new List<Pet>();
}