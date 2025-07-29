using System;
using UnityEngine;

public class DeformableMaterialController : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private Material _material;

    private void Awake()
    {
        _material = _renderer.material;
    }

    public void UpdateHitPosition(Vector3 worldPosition, string id)
    {
        // Перевод в пространство объекта, если нужно:
        Vector3 localPos = transform.InverseTransformPoint(worldPosition);
        Debug.Log("UpdateHitPosition");
        if (id == "Left")
            _material.SetVector("_HitPosition_Left", localPos);
        else if (id == "Right")
            _material.SetVector("_HitPosition_Right", localPos);
    }
}