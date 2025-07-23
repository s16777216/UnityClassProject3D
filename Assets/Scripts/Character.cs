using UnityEngine;

public class Character : MonoBehaviour
{
    [field: Header("基本資料")]
    [field: SerializeField, Range(0, 5)]
    public float MoveSpeed { get; private set; } = 2;
    public StateMachine StateMachine { get; private set; }
    public Animator Animator { get; private set; }
    public Rigidbody Rigidbody { get; private set; }

    protected virtual void Awake()
    {
        StateMachine = new StateMachine();
    }

    protected virtual void Update()
    {
        StateMachine.Update();
    }
}
