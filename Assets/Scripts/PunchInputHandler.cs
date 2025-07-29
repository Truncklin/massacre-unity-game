using UnityEngine;
using Zenject;

public class PunchInputHandler : MonoBehaviour
{
    [Inject(Id = "Left")] private GlovePuncher _leftGlove;
    [Inject(Id = "Right")] private GlovePuncher _rightGlove;
    [Inject] private DeformableMaterialController _material;
    [Inject] private BoxingStateMachine _stateMachine;
    [Inject] private CameraShaker _cameraShaker;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            var punchState = new PunchState(_stateMachine, _leftGlove);
            _stateMachine.SetState(punchState);
            _cameraShaker.Shake();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            var punchState = new PunchState(_stateMachine, _rightGlove);
            _stateMachine.SetState(punchState);
            _cameraShaker.Shake();
        }
        
    }
}