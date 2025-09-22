using UnityEngine;


public class Chicken: Animal    
{
    public override void MakeSound()
    {
      Debug.Log($"{Name} : Cluck Cluck!");
    }
    
    public  void Sleep()
    {
       
        Debug.Log($"{Name} is Sleep Status Hunger:+10 Happiness:+15");
        
    }
    
}
