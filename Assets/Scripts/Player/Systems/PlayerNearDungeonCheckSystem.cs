using Leopotam.Ecs;
using UnityEngine;

public class PlayerNearDungeonCheckSystem : IEcsRunSystem
{
    private SceneData sceneData;
    private EcsFilter<Player> filter;
    public void Run()
    {
        ref var player = ref filter.Get1(0);
        if (Vector2.Distance(sceneData.UpgradesDungeon.position, player._transform.position) < 3)
        {
            player.isNearUpgradesDungeon = true;
        }
        else
        {
            player.isNearUpgradesDungeon = false;
        }
    }
}
