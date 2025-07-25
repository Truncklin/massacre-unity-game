using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderLink : MonoBehaviour
{
    [SerializeField] private GameObject PunchPointL;
    [SerializeField] private GameObject PunchPointR;
    [SerializeField] private GameObject shaderPain;
    private Material _material;
    private Renderer _renderer;

    private void Start()
    {
        // Get the Renderer component first
        _renderer = shaderPain.GetComponent<Renderer>();
        if (_renderer != null)
        {
            // Get the material from the renderer
            _material = _renderer.material;
        }
        else
        {
            Debug.LogError("No Renderer component found on shaderPain GameObject");
        }
    }

    void Update()
    {
        if (_material != null && PunchPointL != null)
        {
            _material.SetVector("_HitPosition", PunchPointL.transform.position);
            _material.SetVector("_HitPosition", PunchPointR.transform.position);
        }
    }
}