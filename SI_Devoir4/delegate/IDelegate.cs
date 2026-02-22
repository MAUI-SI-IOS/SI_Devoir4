




namespace Delegate;

public abstract class IDelegate  {
  public IState state;

  public void SetState(IState state){
      this.state = state;
  }

}
