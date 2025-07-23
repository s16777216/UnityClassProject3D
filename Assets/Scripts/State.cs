public class State
{
    protected string name;
    protected StateMachine stateMachine;
    public virtual void Enter()
    {
        // Code to execute when entering the state
    }
    public virtual void Update()
    {
        // Code to execute every frame while in the state
    }

    public virtual void Exit()
    {
        // Code to execute when exiting the state
    }
}
