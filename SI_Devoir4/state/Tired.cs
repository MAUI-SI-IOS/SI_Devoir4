


using Delegate;

namespace State;


internal class Tired: IState {

  private static IState instance = new Tired();
  
  private Tired(){ }


  public void ChangedState(IDelegate worker)
  {
        worker.state = NotTired.Instance(); 
  }
  
  public  static IState Instance() 
  {
    return instance;
  }
}
