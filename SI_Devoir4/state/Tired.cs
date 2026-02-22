


namespace State;


internal class Tired: IState {

  private static IState instance = new Tired();
  
  private Tired(){ }


  public void ChangeState(IDelegate worker)
  {
    Console.WriteLine("Not tired anymore");
    worker.SetState(NotTired.Instance()); 
  }
  
  public  static IState Instance() 
  {
    return instance;
  }
}
