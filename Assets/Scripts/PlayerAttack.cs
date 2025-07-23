public class PlayerAttack : PlayerState
{
    public PlayerAttack(string name, StateMachine stateMachine, Player player) : base(name, stateMachine, player)
    {
    }
    public override void Enter()
    {
        base.Enter();
        // Additional logic for entering the attack state can be added here
    }
    public override void Exit()
    {
        base.Exit();
        // Additional logic for exiting the attack state can be added here
    }
    public override void Update()
    {
        base.Update();
        // Logic for updating the attack state can be added here
    }
}