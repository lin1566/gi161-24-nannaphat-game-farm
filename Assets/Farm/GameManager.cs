using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    private List<Animal> farmAnimals = new List<Animal>();
    public List<Animal> animalPrefabs;
    public Animal cuurentAnnimal;
    void Start()
    {

       /* farmAnimals.Add(animalPrefabs[0]);
        farmAnimals.Add(animalPrefabs[1]);
        farmAnimals.Add(animalPrefabs[2]);*/

       cuurentAnnimal = Instantiate(animalPrefabs[0]); 
        cuurentAnnimal.Init("Chicken", 20, 40);
        farmAnimals.Add(cuurentAnnimal);

        cuurentAnnimal = Instantiate(animalPrefabs[1]); 
        cuurentAnnimal.Init("Cow", 10, 35);
        farmAnimals.Add(cuurentAnnimal);

        cuurentAnnimal = Instantiate(animalPrefabs[2]); 
        cuurentAnnimal.Init("piggyy", 10, 20);
        farmAnimals.Add(cuurentAnnimal);


        // แสดง stat ของสัตว์ทุกตัว
        foreach (Animal a in farmAnimals)
        {
            a.GetStatus();
        }

        // ให้สัตว์ส่งเสียงกินอาหาร
        foreach (Animal a in farmAnimals)
        {
            a.MakeSound();
            a.Feed(5);                 
                
        }
           
        foreach (Animal a in farmAnimals)
        {
            a.Feed(10,"hay");
            a.GetStatus();
        } // แสดง stat หลังจากให้อาหาร
          
    }
}