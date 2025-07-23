
using UnityEngine;

public class PlayerState : State
{
    protected Player player;

    public PlayerState(string name, StateMachine stateMachine, Player player)
    {
        this.player = player;
        this.name = name;
        this.stateMachine = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log($"進入 {name} 狀態");
    }
}
