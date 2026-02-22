



using State;

namespace Delegate;

public class Nurse : IDelegate
{
    int stamina;
    int staminaPoint;
    string name;

    public Nurse(int stamina, string name): base()
    {
        this.stamina = stamina;
        this.staminaPoint = stamina;
        this.name = name;
    }
    public override void Work()
    {
        if (this.state is NotTired)
        {
            if (staminaPoint == 0)
            {
                Console.WriteLine($"Nurse {name} is tired, calling new worker");
                ChangedState();
                Notify();
            }
            else
            {
                Console.WriteLine($"Nurse {name} is working, {staminaPoint}/{stamina}");
                staminaPoint--;
            }
        }  
    }
    public override void Rest()
    {

        if (staminaPoint == stamina && this.state is Tired)
        {
            ChangedState();
        }
        else if(staminaPoint < stamina)
        {
            Console.WriteLine($"Nurse {name} is resting, {staminaPoint}/{stamina}");
            staminaPoint++;
        }
        else
        {
            Console.WriteLine($"Nurse {name} waiting to work");
        }
       
    }
}
