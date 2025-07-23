public class Player : Character
{
    public PlayerIdle IdleState { get; private set; }
    public PlayerWalk WalkState { get; private set; }
    public PlayerRun RunState { get; private set; }
    public PlayerJump JumpState { get; private set; }
    public PlayerFall FallState { get; private set; }
    public PlayerAttack AttackState { get; private set; }
    public PlayerDead DeadState { get; private set; }

    protected override void Awake()
    {
        base.Awake();

        IdleState = new PlayerIdle($"{name} Idle", StateMachine, this);
        WalkState = new PlayerWalk($"{name} Walk", StateMachine, this);
        RunState = new PlayerRun($"{name} Run", StateMachine, this);
        JumpState = new PlayerJump($"{name} Jump", StateMachine, this);
        FallState = new PlayerFall($"{name} Fall", StateMachine, this);
        AttackState = new PlayerAttack($"{name} Attack", StateMachine, this);
        DeadState = new PlayerDead($"{name} Dead", StateMachine, this);

        StateMachine.Initialize(IdleState);
    }
}
