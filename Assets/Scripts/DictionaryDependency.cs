using Zenject;
using UnityEngine;

public class DictionaryDependency : MonoInstaller
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _leftGlow;
    [SerializeField] private Transform _rightGlow;
    [SerializeField] private Renderer _targetMaterial;

    public override void InstallBindings()
    {
        Container.BindInstance(_animator).AsSingle();
        Container.Bind<Material>().FromMethod(() => _targetMaterial.material)
            .AsSingle().NonLazy();
        Container.Bind<AnimationStateMachine>().AsSingle();
        Container.BindInstance(_leftGlow).WithId("LeftGlow");
        Container.BindInstance(_rightGlow).WithId("RightGlow");
    }
}