using UnityEngine;
using Zenject;

public class AnimationStateMachine : ITickable
{
    private AnimationState _currentState;
    private readonly LeftPunchState _leftPunch;
    private readonly RightPunchState _rightPunch;
    private readonly Renderer _targetRenderer;
    private Material _material;
    
    [Inject]
    public AnimationStateMachine(Renderer targetRenderer)
    {
        _targetRenderer = targetRenderer;
        _material = _targetRenderer.material; // Получаем материал при инициализации
    }

    public AnimationStateMachine(
        LeftPunchState leftPunch, 
        RightPunchState rightPunch)
    {
        _leftPunch = leftPunch;
        _rightPunch = rightPunch;
    }

    public void Tick()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeState(_leftPunch);
            _material.SetVector("_PunchPosition", _leftPunch._hand.position);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeState(_rightPunch);
            _material.SetVector("_PunchPosition", _rightPunch._hand.position);
        }

        _currentState?.Update();
    }

    private void ChangeState(AnimationState newState)
    {
        _currentState?.Exit();
        _currentState = newState;
        _currentState.Enter();
    }
}