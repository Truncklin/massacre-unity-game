using UnityEngine;
using Zenject;

public abstract class AnimationState
{
    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();
}

public class LeftPunchState : AnimationState
{
    private readonly Animator _animator;
    public readonly Transform _hand;

    public LeftPunchState(Animator animator, [Inject(Id = "LeftGlow")] Transform hand)
    {
        _animator = animator;
        _hand = hand;
    }

    public override void Enter()
    {
        _animator.Play("glow(r)");
    }

    public override void Update() { }

    public override void Exit()
    {
        _animator.Play("idle(l)");
    }
}

public class RightPunchState : AnimationState
{
    private readonly Animator _animator;
    public readonly Transform _hand;

    public RightPunchState(Animator animator, [Inject(Id = "RightGlow")] Transform hand)
    {
        _animator = animator;
        _hand = hand;
    }

    public override void Enter()
    {
        _animator.Play("glow(l)");
    }

    public override void Update() { }

    public override void Exit()
    {
        _animator.Play("idle(l)");
    }
}