using Leopotam.Ecs;
using UnityEngine;

public class EasyEnemyAttackSystem : IEcsRunSystem
{
    private StaticData staticData;
    private EcsFilter<Player> playerFilter;
    private EcsFilter<EasyEnemy> easyEnemyFilter;
    public void Run()
    {
        ref var player = ref playerFilter.Get1(0);

        foreach (var i in easyEnemyFilter)
        {
            ref var easyEnemy = ref easyEnemyFilter.Get1(i);

            if (easyEnemy.easyEnemyGO.activeSelf && Vector2.Distance(easyEnemy._transform.position, player._transform.position) < 3)
            {
                if (easyEnemy.timeToAttack <= 0)
                {
                    player.HP -= easyEnemy.damage;
                    easyEnemy.timeToAttack = staticData.enemyAttackTime;
                }
                else
                {
                    easyEnemy.timeToAttack -= Time.deltaTime;
                }
            }
        }
    }
}
