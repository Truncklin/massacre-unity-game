using UnityEngine;
using Zenject;

public class GlovePositionUpdater : MonoBehaviour
{
    [Inject(Id = "Left")] private GlovePuncher _leftGlove;
    [Inject(Id = "Right")] private GlovePuncher _rightGlove;
    [Inject] private DeformableMaterialController _material;

    private void Update()
    {
        Debug.Log("GlovePositionUpdate");
        _material.UpdateHitPosition(_leftGlove.HitPoint.position, "Left");
        _material.UpdateHitPosition(_rightGlove.HitPoint.position, "Right");
    }
}