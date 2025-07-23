public class StateMachine
{
    private State currentState;

    public void Initialize(State initialState)
    {
        currentState = initialState;
        currentState.Enter();
    }

    public void Update()
    {
        currentState.Update();
    }

    public void SwitchState(State newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
