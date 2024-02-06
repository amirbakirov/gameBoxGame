using Leopotam.Ecs;
using UnityEngine;

public class PlayerDieSystem : IEcsRunSystem
{
    private RuntimeData runtimeData;
    private SceneData sceneData;
    private EcsFilter<Player, Round> playerFilter;
    public void Run()
    {
        ref var player = ref playerFilter.Get1(0);
        ref var round = ref playerFilter.Get2(0);

        if (player.HP <= 0)
        {
            sceneData.ladders.SetActive(true);
            player._transform.position = sceneData.playerSpawnPoint.position;
            round.current_round = 0;
            sceneData.roundText.gameObject.SetActive(false);
            sceneData.ladders.SetActive(true);
            sceneData.roundText.gameObject.SetActive(false);
            for (int i = 0; i < runtimeData.round1Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round1Enemies[i].Get<EasyEnemy>();
                easyEnemy.easyEnemyGO.SetActive(false);
            }
            for (int i = 0; i < runtimeData.round2Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round2Enemies[i].Get<EasyEnemy>();
                easyEnemy.easyEnemyGO.SetActive(false);
            }
            for (int i = 0; i < runtimeData.round3Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round3Enemies[i].Get<EasyEnemy>();
                easyEnemy.easyEnemyGO.SetActive(false);
            }
            for (int i = 0; i < runtimeData.round4Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round4Enemies[i].Get<EasyEnemy>();
                easyEnemy.easyEnemyGO.SetActive(false);
            }
            for (int i = 0; i < runtimeData.round5Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round5Enemies[i].Get<EasyEnemy>();
                easyEnemy.easyEnemyGO.SetActive(false);
            }
            for (int i = sceneData.coinsOnScene.Count - 1; i >= 0; i--)
            {
                GameObject coin = sceneData.coinsOnScene[i];
                sceneData.coinsOnScene.Remove(coin);
                Object.Destroy(coin);
            }
            player.HP = player.maxHP;
        }
    }
}
