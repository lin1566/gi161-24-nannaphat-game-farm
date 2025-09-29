using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   //private List<Animal> farmAnimals = new List<Animal>();
    public List<Animal> animalPrefabs;
   /* public Animal cuurentAnnimal;*/
    private List<Animal> animals = new List<Animal>();
    

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
        //chicky.Animal("John_Hero",FoodType.Grain);

        Debug.Log($"There are {animals.Count} animals living in the Happy Farm");

        
        foreach (Animal animal in animals)
        {
            animal.Status();
        }

        Debug.Log("🐔🐮🐷");// LOOPดูสถานะของสัตว์แต่ละตัว

        // ✅ วนลูปให้สัตว์ทำงาน
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            // ให้อาหารแบบ generic
            animal.Feed(5);
            // ให้อาหารแบบที่สัตว์ชอบ
        }
        Debug.Log("🐄🐄🐄🐄🐄🐄🐄🐄🐄🐄🐄🐄🐄");
        
        foreach (Animal animal in animals)
        {
            if (animal is Cow)
            {
                animal.Feed(10);
                animal.Feed(animal.PreferedFood, 20);
                
                Debug.Log($"{animal.Name} produced: {animal.Produce()}");
            }
            
        }
        
        for (int i = 0; i < 2; i++) //เมธทอธ เรียกซ้ำ 2 รอบ
        {
            foreach (Animal animal in animals)
            {
                if (animal is Cow)
                {
                    animal.Feed(animal.PreferedFood,30);
                    Debug.Log($"{animal.Name} produced: {animal.Produce()}");
                }

            }
        }

        Debug.Log("🐔🐔🐔🐔🐔🐔🐔🐔");
        foreach (Animal animal in animals)
        {
            if (animal is Chicken)
            {
                animal.Feed(10);
                animal.Feed(animal.PreferedFood, 20);
                
                Debug.Log($"{animal.Name} produced: {animal.Produce()}");
            }
            
        }
        
        for (int i = 0; i < 2; i++) //เมธทอธ เรียกซ้ำ 2 รอบ
        {
            foreach (Animal animal in animals)
            {
                if (animal is Chicken)
                {
                    animal.Feed(FoodType.RottenMeat,30);
                    Debug.Log($"{animal.Name} produced: {animal.Produce()}");
                }

            }
        }

        Debug.Log("🐷🐷🐷🐷🐷🐷🐷🐷");
        foreach (Animal animal in animals)
        {
            if (animal is Pig)
            {
                animal.Feed(10);
                animal.Feed(animal.PreferedFood, 20);
                
                Debug.Log($"{animal.Name} produced: {animal.Produce()}");
            }
            
        }
        
        for (int i = 0; i < 2; i++) //เมธทอธ เรียกซ้ำ 2 รอบ
        {
            foreach (Animal animal in animals)
            {
                if (animal is Pig)
                {

                    animal.Feed(animal.PreferedFood,30);
                    Debug.Log($"{animal.Name} produced: {animal.Produce()}");
                }

            }
        }
       
     
      
    }
}
