public class PunchState : IPunchState
{
    private readonly GlovePuncher _glove;
    private readonly BoxingStateMachine _stateMachine;

    public PunchState(BoxingStateMachine stateMachine, GlovePuncher glove)
    {
        _glove = glove;
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        _glove.PlayPunchAnimation();
    }

    public void Tick()
    {
        // можно добавить переход назад в Idle по таймеру
    }

    public void Exit() { }
}