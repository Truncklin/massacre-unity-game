public class IdleState : IPunchState
{
    private readonly BoxingStateMachine _stateMachine;

    public IdleState(BoxingStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter() { }
    public void Tick() { }
    public void Exit() { }
}