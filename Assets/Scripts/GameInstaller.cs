using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private GlovePuncher _leftGlove;
    [SerializeField] private GlovePuncher _rightGlove;
    [SerializeField] private DeformableMaterialController _material;
    [SerializeField] private PunchInputHandler _inputHandler;
    [SerializeField] private GlovePositionUpdater _glovePositionUpdater;
    [SerializeField] private CameraShaker _cameraShaker;

    public override void InstallBindings()
    {
        Debug.Log("=== GameInstaller bindings applied ===");
        Container.BindInstance(_leftGlove).WithId("Left").AsCached();
        Container.BindInstance(_rightGlove).WithId("Right").AsCached();
        Container.BindInstance(_material).AsSingle();
        Container.BindInstance(_glovePositionUpdater).AsSingle();
        Container.BindInstance(_cameraShaker).AsSingle();
        Container.BindInterfacesAndSelfTo<BoxingStateMachine>().AsSingle();

        Container.BindInstance(_inputHandler).AsSingle();
    }
}