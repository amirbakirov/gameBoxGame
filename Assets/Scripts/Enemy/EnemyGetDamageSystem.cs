using Leopotam.Ecs;
using UnityEngine;

public class EnemyGetDamageSystem : IEcsRunSystem
{
    private StaticData staticData;
    private SceneData sceneData;

    private EcsFilter<Player> playerFilter;
    private EcsFilter<EasyEnemy> easyEnemyFilter;

    public void Run()
    {
        ref var player = ref playerFilter.Get1(0);
        foreach (var i in easyEnemyFilter)
        {
            ref var easyEnemy = ref easyEnemyFilter.Get1(i);

            if (easyEnemy.enemyTriggerCheck.isAttackedBySword || easyEnemy.enemyTriggerCheck.isAttackedBySwordBullet)
            {
                easyEnemy.enemyTriggerCheck.isAttackedBySword = false;
                easyEnemy.enemyTriggerCheck.isAttackedBySwordBullet = false;
                easyEnemy.HP -= player.swordDamage;
            }
            else if (easyEnemy.enemyTriggerCheck.isAttackedByGunStoneBullet || easyEnemy.enemyTriggerCheck.isAttackedByGunArrowBullet)
            {
                easyEnemy.enemyTriggerCheck.isAttackedByGunStoneBullet = false;
                easyEnemy.enemyTriggerCheck.isAttackedByGunArrowBullet = false;
                easyEnemy.HP -= player.gunDamage;
            }
            if (easyEnemy.HP <= 0)
            {
                if (easyEnemy.isCoinCanInstantiate)
                {
                    GameObject coinGO = Object.Instantiate(staticData.coin, easyEnemy._transform.position, Quaternion.identity);
                    float dirX = 0;
                    if (easyEnemy._transform.position.x < player._transform.position.x)
                    {
                        dirX = -5;
                    }
                    else
                    {
                        dirX = 5;
                    }
                    coinGO.GetComponent<Rigidbody2D>().AddForce(new Vector2(dirX, 2) * 50);
                    easyEnemy.isCoinCanInstantiate = false;
                    sceneData.coinsOnScene.Add(coinGO);
                }
                easyEnemy.easyEnemyGO.SetActive(false);
            }
        }
    }
}
