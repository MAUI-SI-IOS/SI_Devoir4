using State;
using System.Diagnostics.Metrics;

namespace Delegate;


public class Doctor: IDelegate 
{
    int stamina;
    int staminaPoint;
    string name;
    public Doctor(int stamina, string name): base()
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
                Console.WriteLine($"{id}Doctor {name} is Tired, calling new worker");
                ChangedState();
                Notify();
            }
            else
            {
                Console.WriteLine($"Doctor {name} is working, {staminaPoint}/{stamina}");
                staminaPoint--;
            }
        }
    }

    public override void Rest()
    {   
        if (this.state is Tired)
        {
            if (staminaPoint == stamina)
            {
                Console.WriteLine($"Doctor {name} is ready to work");
                ChangedState();
                Notify();
            }
            else
            {
                Console.WriteLine($"Doctor {name} is resting, {staminaPoint}/{stamina}");
                staminaPoint++;
            }

        }
    }

}
