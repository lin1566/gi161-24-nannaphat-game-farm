using UnityEngine;
public enum FoodType
{
    Hay,        // Cow �ͺ
    Grain,      // Chicken �ͺ
    Scraps,     // Pig �ͺ
    RottenMeat, // �ء������ͺ
    AnimalFood  // ����÷����
}
public abstract class Animal : MonoBehaviour
{
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }

   // protected FoodType PreferredFood;
    public FoodType PreferedFood { get; protected set; }


    protected int MinValue = 0;
    protected int MaxValue = 100;

    public Animal(string name, FoodType preferredFood)
    {
        Name = name;
        Hunger = 50;
        Happiness = 50;
        PreferedFood = preferredFood;
    }
   /* protected virtual void Awake()
    {
        if (Hunger == 0) Hunger = 50;
        if (Happiness == 0) Happiness = 50;
    }*/

    public void AdjustHunger(int amount)
    {
        Hunger += amount;
        if (Hunger < 0) Hunger = 0;
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
        if (Happiness > 100) Happiness = 100; // ����� max happiness = 100
    }
    public void Status()
    {
        Debug.Log($"{Name} -> Hunger: {Hunger} | Happiness: {Happiness} | Prefered Food: {PreferedFood}");
    }

    // Feed Ẻ 1
    public void Feed(int amount)
    {
        Hunger = Mathf.Max(MinValue, Hunger - amount);
        Happiness = Mathf.Min(MaxValue, Happiness + amount / 2);

        Debug.Log($"{Name} was fed {amount} units of generic food. Current Happiness: {Happiness}");
    }

    // Feed Ẻ 2
    public void Feed(FoodType food, int amount)
    {
        if (food == PreferedFood)
        {
            Hunger = Mathf.Max(MinValue, Hunger - amount);
            Happiness = Mathf.Min(MaxValue, Happiness + 15);
            Debug.Log($"{Name} was fed {amount} units of preferred food : {food}, Happiness increased 15 units, Current Happiness: {Happiness}");
        }
        else if (food == FoodType.RottenMeat)
        {
            Happiness = Mathf.Max(MinValue, Happiness - 20);
            Debug.Log($"{Name} was fed with rotten food : {food}. Unhappy! Happiness decreased 20 units, Current Happiness: {Happiness}");
        }
        else
        {
            Feed(amount); // �� logic Ẻ generic
        }
    }

    public abstract void MakeSound();
    public abstract string Produce();
}
