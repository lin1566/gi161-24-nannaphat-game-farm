using System;
using UnityEngine;

public abstract class Animal : MonoBehaviour
    //abstract
{
    private string name;
    private int hunger;
    private int happiness;

    public string Name
    {
        get => name;
        set => name = string.IsNullOrEmpty(value) ? "Unknown" : value;
    }

    public int Hunger
    {
        get { return hunger; }
        set
        {

            if (value < 0) hunger = 0;
            else if (value > 50) hunger = 50;
            else hunger = value;
        }
    }

    public int Happiness
    {

        get { return happiness; }
        set
        {
            if (value < 0) happiness = 0;
            else if (value > 50) happiness = 50;
            else happiness = value;
        }
    }

    public void Init(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
    }

    public void AdjustHunger(int cost)
    {
        Hunger += cost;
    }

    public void AsjustHappiness(int cost)
    {
        Happiness += cost;
    }
    public virtual void MakeSound() //Overiding ( virtual ) ใส่เข้าไปแล้วฝั่งลูกห็ใส่ override ด้วย จะได้เรียกได้
    {
        Debug.Log("Animal makes a sound.");
    }
    public  void Feed(int cost) //overloading 
    {
        AdjustHunger(cost);
        Debug.Log($"{Name}  fed {cost} units of food.");
    }
    public  void Feed(int cost,string food) //overliading
    {
        AdjustHunger(cost);
        Debug.Log($"{Name} was fed {cost} units of {food}.");
    }
    public void GetStatus()
    {
        Debug.Log($"{Name}-> Hunger: {Hunger} | Happiness: {Happiness}");
    }

    
}
