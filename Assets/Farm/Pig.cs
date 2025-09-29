using UnityEngine;

public class Pig : Animal
{
    public int Pork { get; private set; }

    public Pig(string name) : base(name, FoodType.Scraps) // สมมติว่าหมูกิน AnimalFood
    {
        Pork = 0;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Oink! 🐷");
    }

    public override string Produce()
    {
        Pork++;
        return $"Pork {Pork}";
    }
}
