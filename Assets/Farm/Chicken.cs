using UnityEngine;


public class Chicken
{
    private string name;
    private int hunger;
    private int happiness;
    private int eggs;

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
    public int Eggs
    { get; private set; }


    public  Chicken(string Newname, int Newhunger, int Newhappiness, int eggs)
    {
        Name = Newname;
        Hunger = Newhunger;
        Happiness = Newhappiness;
        Eggs = eggs;
        GetStatus();//ค่าเริ่มต้น ก่อนแปลงเปลี่ยนค่าสถานะ
    }
    public void AdjustHunger(int cost)
    {
        Hunger += cost;
    }
    public void AdjustHappiness(int cost)
    {
        Happiness += cost;
    }
    public void MakeSound()
    {
        GetStatus();
        AdjustHappiness(10);
        Debug.Log($"{Name} : Cluck Cluck!");
    }
    public void Feed(string food)
    {
        Debug.Log($"{Name} is eating {food}. Status Hunger:-5 Happiness:+5");
        AdjustHunger(-5);
        AdjustHappiness(5);
    }
    
    public void Sleep()
    {
       
        AdjustHunger(10);
        AdjustHappiness(15);
        Debug.Log($"{Name} is Sleep Status Hunger:+10 Happiness:+15");
        
    }
    public void GetStatus()//จะเอาไว้แสดงค่าทั้งหมด
    {
        Debug.Log($"****Chicken :{Name}, Hunger : {Hunger}/50 , Happiess :{Happiness}/50 ,Eggs {Eggs}****");
    }
    
}
