
using UnityEngine;

public class Pig : Animal
{
    public override void MakeSound()
    {
        Debug.Log($"{Name} says Oink Oink");
    }

   
}
