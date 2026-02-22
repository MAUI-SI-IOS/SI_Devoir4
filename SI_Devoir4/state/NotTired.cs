using Delegate;

namespace State;


internal class NotTired: IState {

  private static IState instance = new NotTired();
  
  private NotTired() { }

  
  public void ChangedState(Member worker)
  {
        worker.state = Tired.Instance();
  }
  
  public static IState Instance() 
  {
        return instance;
  }

}

