using UnityEngine;

public class Chicken : Animal
{
    public int Eggs { get; private set; }

    public Chicken(string name) : base(name, FoodType.Grain) // ไก่ชอบเมล็ดพืช
    {
        Eggs = 0;
    }

    public void  Sleep()
    {
        Debug.Log($"{Name} is sleeping... ZZZZZZZZ");
        AdjustHappiness(5);
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Cluck!Cluck! ");
    }

    public override string Produce()
    {
        Eggs++;
        return $"Egg {Eggs}";
    }
}
