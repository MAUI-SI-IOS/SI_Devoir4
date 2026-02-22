




using State;
using Observer;

namespace Delegate;


public abstract class IDelegate: ISubject  {
    static private int counter = 0;
    internal int id { get; set; }
    internal IState state;
    private Team? observer;

    public IDelegate()
    {
        this.id = IDelegate.counter;
        IDelegate.counter ++;
        this.state = NotTired.Instance();
    }


    //On changed state we notify
    public void ChangedState(){
        this.state.ChangedState(this);
    }
    internal void SetTeam(Team team)// subscribe
    {
        this.observer = team;
    }

    public void Notify()
    {
        this.observer?.Update(); 
    }
  
    public abstract void Work();
    public abstract void Rest();
}
