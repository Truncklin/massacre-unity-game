using System;
using UnityEngine;

public class GlovePuncher : MonoBehaviour
{
    [SerializeField] private Transform _hitPoint;
    [SerializeField] private Animator _animator;

    public Transform HitPoint => _hitPoint;
    

    public void PlayPunchAnimation()
    {
        _animator.SetTrigger("punch");
    }
}