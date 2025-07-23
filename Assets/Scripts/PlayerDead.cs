public class PlayerDead : PlayerState
{
    public PlayerDead(string name, StateMachine stateMachine, Player player) : base(name, stateMachine, player)
    {
    }
    public override void Enter()
    {
        base.Enter();
        // Additional logic for entering the dead state can be added here
        //player.Die();
    }
    public override void Exit()
    {
        base.Exit();
        // Additional logic for exiting the dead state can be added here
    }
    public override void Update()
    {
        base.Update();
        // Logic for updating the dead state can be added here
    }
}