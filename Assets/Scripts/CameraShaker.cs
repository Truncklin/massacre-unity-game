using DG.Tweening;
using UnityEngine;

public class CameraShaker: MonoBehaviour
{
    public void Shake()
    {
        if (Camera.main != null) Camera.main.transform.DOShakePosition(0.2f, 0.3f, 10, 90, false);
    }
}