using State;

namespace Delegate;


public class Paramedic: IDelegate 
{
    int stamina;
    int staminaPoint;
    string name;

    public Paramedic(int stamina, string name)
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
                Console.WriteLine($"Paramedic {name} is Tired, calling new worker");
                ChangedState();
                Notify();
            }
            else
            {
                Console.WriteLine($"Paramedic {name} is working, {staminaPoint}/{stamina}");
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
            Console.WriteLine($"Paramedic {name} is resting, {staminaPoint}/{stamina}");
            staminaPoint++;
        }
        else
        {
            Console.WriteLine($"Nurse {name} waiting to work");
        }
    }
}
