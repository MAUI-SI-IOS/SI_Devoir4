

namespace State;


internal class NotTired: IState {

  private static IState instance = new NotTired();
  
  private NotTired() { }

  
  public void ChangeState(IDelegate worker)
  {
    Console.WriteLine("Not tired anymore");
    worker.SetState(NotTired.Instance()); 
  }
  
  public static IState Instance() 
  {
    return instance;
  }

}

