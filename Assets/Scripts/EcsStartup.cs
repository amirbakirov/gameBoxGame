using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;

public class EcsStartup : MonoBehaviour
{
    public EcsWorld ecsWorld;
    private EcsSystems updateSystems;
    private EcsSystems fixedUpdateSystems;

    public StaticData config;
    public SceneData sceneData;

    private void Awake()
    {
        ecsWorld = new EcsWorld();
        updateSystems = new EcsSystems(ecsWorld);
        fixedUpdateSystems = new EcsSystems(ecsWorld);
        
        RuntimeData runtimeData = new RuntimeData();

        updateSystems
            .Inject(config)
            .Inject(sceneData)
            .Inject(runtimeData)
            .Add(new PlayerInitSystem())
            .Add(new PlayerInputSystem())
            .Add(new PlayerJumpSystem())
            .Add(new PlayerAttackSystem())
            .Add(new PlayerUISystem())
            .Add(new PlayerCoinSystem())
            .Add(new PlayerDieSystem())
            .Add(new EasyEnemyInitSystem(1))
            .Add(new EasyEnemyInitSystem(1))
            .Add(new EasyEnemyInitSystem(2))
            .Add(new EasyEnemyInitSystem(2))
            .Add(new EasyEnemyInitSystem(2))
            .Add(new EasyEnemyInitSystem(2))
            .Add(new EasyEnemyInitSystem(3))
            .Add(new EasyEnemyInitSystem(3))
            .Add(new EasyEnemyInitSystem(3))
            .Add(new EasyEnemyInitSystem(3))
            .Add(new EasyEnemyInitSystem(3))
            .Add(new EasyEnemyInitSystem(3))
            .Add(new EasyEnemyInitSystem(4))
            .Add(new EasyEnemyInitSystem(4))
            .Add(new EasyEnemyInitSystem(4))
            .Add(new EasyEnemyInitSystem(4))
            .Add(new EasyEnemyInitSystem(4))
            .Add(new EasyEnemyInitSystem(4))
            .Add(new EasyEnemyInitSystem(5))
            .Add(new EasyEnemyInitSystem(5))
            .Add(new EasyEnemyInitSystem(5))
            .Add(new EasyEnemyInitSystem(5))
            .Add(new EasyEnemyInitSystem(5))
            .Add(new EasyEnemyInitSystem(5))
            .Add(new EnemyGetDamageSystem())
            .Add(new EasyEnemyAttackSystem())
            .Add(new CameraFollowSystem())
            .Add(new PlayerEnteringIntoUpgradesSystem())
            .Add(new PlayerUpgradeSystem())
            .Add(new PlayerNearDungeonCheckSystem())
            .Add(new LaddersActiveSelfSystem())
            .Add(new RoundsManagerSystem());
        fixedUpdateSystems
            .Add(new PlayerMoveSystem())
            .Add(new PlayerLadderMoveSystem())
            .Add(new EasyEnemyMoveSystem());

        updateSystems.Init();
        fixedUpdateSystems.Init();
    }

    private void Update()
    {
        updateSystems?.Run();
    }
    private void FixedUpdate()
    {
        fixedUpdateSystems?.Run();
    }

    private void OnDestroy()
    {
        updateSystems?.Destroy();
        updateSystems = null;
        fixedUpdateSystems?.Destroy();
        fixedUpdateSystems = null;
        ecsWorld?.Destroy();
        ecsWorld = null;
    }
}
