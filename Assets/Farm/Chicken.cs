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
        Debug.Log($"{Name} is sleeping... ");
        AdjustHappiness(5);
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Cluck!Cluck! 🐔");
    }

    /*public override string Produce()
    {
        Eggs++;
        return $"Egg {Eggs}";
    }*/
    
    public override string Produce()
{

    if (Happiness < 50)
        return $"{Name} is not happy enough to produce eggs.";

    int eggsProduced = Happiness < 80 ? 3 : 2;
    Eggs += eggsProduced;

       //AdjustHappiness(-); // อยากให้เหมือน เลย ให้Happiness ลง 10 ทุกครั้งที่ผลิตไข่ แต่ไม่เหมือน 555

    return $"{Name} produced {eggsProduced} egg(s). Total eggs: {Eggs}";
       
}



}
