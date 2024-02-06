using Leopotam.Ecs;
using UnityEngine;

public class EasyEnemyMoveSystem : IEcsRunSystem
{
    private EcsFilter<EasyEnemy> easyEnemyFilter;
    private EcsFilter<Player> playerFilter;
    public void Run()
    {
        ref var player = ref playerFilter.Get1(0);
        foreach (var i in easyEnemyFilter)
        {
            ref var easyEnemy = ref easyEnemyFilter.Get1(i);
            if (Vector2.Distance(easyEnemy._transform.position, player._transform.position) < 8 &&
                Vector2.Distance(easyEnemy._transform.position, player._transform.position) > 2)
            {
                if (easyEnemy._transform.position.x < player._transform.position.x)
                {
                    easyEnemy.easyEnemyRb.velocity = new Vector2(easyEnemy.easyEnemyMoveSpeed, easyEnemy.easyEnemyRb.velocity.y);
                }
                else
                {
                    easyEnemy.easyEnemyRb.velocity = new Vector2(-1 * easyEnemy.easyEnemyMoveSpeed, easyEnemy.easyEnemyRb.velocity.y);
                }
            }
            else
            {
                easyEnemy.easyEnemyRb.velocity = new Vector2(0, easyEnemy.easyEnemyRb.velocity.y);
            }
        }
    }
}
