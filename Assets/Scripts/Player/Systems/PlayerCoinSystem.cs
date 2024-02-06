using Leopotam.Ecs;
using UnityEngine;

public class PlayerCoinSystem : IEcsRunSystem
{
    private SceneData sceneData;
    private EcsFilter<Player> playerFilter;
    
    public void Run()
    {
        ref var player = ref playerFilter.Get1(0);

        if (player.playerCoinTriggerCheck.coin != null)
        {
            GameObject coin = player.playerCoinTriggerCheck.coin;
            sceneData.coinsOnScene.Remove(coin);
            Object.Destroy(coin);
            player.playerCoinTriggerCheck.coin = null;
            player.coins += player.coinsPerEnemyDeath;
        }
    }
}
