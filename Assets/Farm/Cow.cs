using UnityEngine;

public class Cow :Animal
{
   
    
    public override void MakeSound()
    {
        Debug.Log($"{Name} says Moo!");
    }

    public void Moo()
    {
       
        Debug.Log($"{Name} gives some ");
    }
   
    

}


