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
        if (Happiness > 70)
        {
            float milkProduced = Happiness / 10f; // ปริมาณนมที่ผลิตได้ในรอบนี้
            Milk += milkProduced;            // ✅ สะสมเพิ่มเข้าไป
            return $"Total Milk: {Milk:F1} units";
        }
        else
        {
            return $"{Name} is not happy enough to produce milk.";
        }
    }
}
