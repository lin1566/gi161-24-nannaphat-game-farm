using UnityEngine;

public class Cow
{
    string name;
    int hunger;
    int happiness;
    float milk;
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
    public int Milk
    { get; private set; }


    public Cow(string Newname, int Newhunger, int Newhappiness, int milk)
    {
        Name = Newname;
        Hunger = Newhunger;
        Happiness = Newhappiness;
        Milk = milk;
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

        Debug.Log($"{Name} : Momo~~~");
    }
    public void Feed(string food)
    {
        Debug.Log($"{Name} is eating {food}. Status Hunger:-5 Happiness:+5");
        AdjustHunger(-5);
        AdjustHappiness(5);
        GetStatus();
    }
    public void Moo()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} is Say: Momo Happiness:+10");
        

    }
   
    public void GetStatus()//จะเอาไว้แสดงค่าทั้งหมด
    {
        Debug.Log($"///Cow :{Name}, Hunger : {Hunger}/50 , Happiess :{Happiness}/50 ,Milk : {Milk}///");
    }

}


