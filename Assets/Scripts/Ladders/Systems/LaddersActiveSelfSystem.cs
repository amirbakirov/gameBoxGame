using Leopotam.Ecs;
using UnityEngine;

public class LaddersActiveSelfSystem : IEcsRunSystem
{
    private SceneData sceneData;
    private EcsFilter<Player> filter;
    public void Run()
    {
        ref var player = ref filter.Get1(0);
        if (player.playerGroundCheck.isArenaGrounded)
        {
            sceneData.ladders.SetActive(false);
        }
    }
}
