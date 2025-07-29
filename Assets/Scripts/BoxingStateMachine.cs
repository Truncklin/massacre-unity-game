using Zenject;

public class BoxingStateMachine : ITickable
{
    private IPunchState _currentState;

    public void SetState(IPunchState state)
    {
        _currentState?.Exit();
        _currentState = state;
        _currentState.Enter();
    }

    public void Tick()
    {
        _currentState?.Tick();
    }
}