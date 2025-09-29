using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   /* private List<Animal> farmAnimals = new List<Animal>();
    public List<Animal> animalPrefabs;
    public Animal cuurentAnnimal;*/
    public List<Animal> animals = new List<Animal>();

    void Start()
    {
        Debug.Log("*** Welcome to Happy Farm Sim ***");

        foreach (Animal animal in animals)
        {
            animal.Status();
        }

        //add
        animals.Add(new Chicken("Chicky"));
        animals.Add(new Cow("Milky"));
        animals.Add(new Pig("Piggy"));

        Debug.Log($"There are {animals.Count} animals living in the Happy Farm");

        
        foreach (Animal animal in animals)
        {
            animal.Status();
        }

        Debug.Log("--------------------------");// LOOPดูสถานะของสัตว์แต่ละตัว

        // ✅ วนลูปให้สัตว์ทำงาน
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            // ให้อาหารแบบ generic
            animal.Feed(5);
            // ให้อาหารแบบที่สัตว์ชอบ
        }
        Debug.Log("--------------------------");
        foreach (Animal animal in animals)
        {
            // ให้อาหารแบบที่สัตว์ชอบ
            animal.Feed(animal.PreferedFood, 20);
            // สร้าง resource
            Debug.Log($"{animal.Name} produced: {animal.Produce()}");
        }
    }
}
