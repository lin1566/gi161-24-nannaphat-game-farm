using UnityEngine;

public class Cow : Animal
{
    public float Milk { get; private set; }

    public Cow(string name) : base(name, FoodType.Hay) // วัวชอบหญ้าแห้ง
    {
        Milk = 0f;
    }

    public void Moo()
    {
        Debug.Log($"{Name} says: Moo~ 🐄");
    }

    public override void MakeSound()
    {
        Moo();
    }

    public override string Produce()
    {
        Milk += 1.5f; // สมมติผลิตนม 1.5 ลิตร
        return $"Milk {Milk} L";
    }
}
