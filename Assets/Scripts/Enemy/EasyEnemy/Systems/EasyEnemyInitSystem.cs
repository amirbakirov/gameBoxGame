using Leopotam.Ecs;
using UnityEngine;

public class EasyEnemyInitSystem : IEcsInitSystem
{
    private EcsWorld ecsWorld;
    private StaticData staticData;
    private SceneData sceneData;
    private RuntimeData runtimeData;

    private EnemyTriggerCheck triggerCheck;

    private int round_num;
    public EasyEnemyInitSystem(int round_num)
    {
        this.round_num = round_num;
    }

    public void Init()
    {
        if (round_num == 1)
        {
            EcsEntity easyEnemyEntity = ecsWorld.NewEntity();
            ref var easyEnemy = ref easyEnemyEntity.Get<EasyEnemy>();

            GameObject easyEnemyGO = Object.Instantiate(staticData.enemyPrefab, sceneData.easyEnemyRound1SpawnPoints[runtimeData.round1Enemies.Count].position, Quaternion.identity);
            easyEnemy.easyEnemyRb = easyEnemyGO.GetComponent<Rigidbody2D>();
            easyEnemy.easyEnemyGO = easyEnemyGO.gameObject;
            easyEnemy._transform = easyEnemyGO.GetComponent<Transform>();
            easyEnemy.startPos = easyEnemyGO.transform.position;
            easyEnemy.easyEnemyMoveSpeed = staticData.easyEnemyMoveSpeed;
            triggerCheck = easyEnemyGO.GetComponent<EnemyTriggerCheck>();
            easyEnemy.enemyTriggerCheck = triggerCheck;
            easyEnemy.MaxHP = staticData.easyEnemyMaxHP;
            easyEnemy.HP = easyEnemy.MaxHP;
            easyEnemy.damage = staticData.easyEnemyDamage;
            easyEnemy.isCoinCanInstantiate = true;
            easyEnemy.timeToAttack = staticData.enemyAttackTime;
            easyEnemyGO.SetActive(false);

            runtimeData.round1Enemies.Add(easyEnemyEntity);
        }
        else if (round_num == 2)
        {
            EcsEntity easyEnemyEntity = ecsWorld.NewEntity();
            ref var easyEnemy = ref easyEnemyEntity.Get<EasyEnemy>();

            GameObject easyEnemyGO = Object.Instantiate(staticData.enemyPrefab, sceneData.easyEnemyRound2SpawnPoints[runtimeData.round2Enemies.Count].position, Quaternion.identity);
            easyEnemy.easyEnemyRb = easyEnemyGO.GetComponent<Rigidbody2D>();
            easyEnemy.easyEnemyGO = easyEnemyGO.gameObject;
            easyEnemy._transform = easyEnemyGO.GetComponent<Transform>();
            easyEnemy.startPos = easyEnemyGO.transform.position;
            easyEnemy.easyEnemyMoveSpeed = staticData.easyEnemyMoveSpeed;
            triggerCheck = easyEnemyGO.GetComponent<EnemyTriggerCheck>();
            easyEnemy.enemyTriggerCheck = triggerCheck;
            easyEnemy.MaxHP = staticData.easyEnemyMaxHP;
            easyEnemy.HP = easyEnemy.MaxHP;
            easyEnemy.damage = staticData.easyEnemyDamage;
            easyEnemy.isCoinCanInstantiate = true;
            easyEnemy.timeToAttack = staticData.enemyAttackTime;
            easyEnemyGO.SetActive(false);

            runtimeData.round2Enemies.Add(easyEnemyEntity);
        }
        else if (round_num == 3)
        {
            EcsEntity easyEnemyEntity = ecsWorld.NewEntity();
            ref var easyEnemy = ref easyEnemyEntity.Get<EasyEnemy>();

            GameObject easyEnemyGO = Object.Instantiate(staticData.enemyPrefab, sceneData.easyEnemyRound3SpawnPoints[runtimeData.round3Enemies.Count].position, Quaternion.identity);
            easyEnemy.easyEnemyRb = easyEnemyGO.GetComponent<Rigidbody2D>();
            easyEnemy.easyEnemyGO = easyEnemyGO.gameObject;
            easyEnemy._transform = easyEnemyGO.GetComponent<Transform>();
            easyEnemy.startPos = easyEnemyGO.transform.position;
            easyEnemy.easyEnemyMoveSpeed = staticData.easyEnemyMoveSpeed;
            triggerCheck = easyEnemyGO.GetComponent<EnemyTriggerCheck>();
            easyEnemy.enemyTriggerCheck = triggerCheck;
            easyEnemy.MaxHP = staticData.easyEnemyMaxHP;
            easyEnemy.HP = easyEnemy.MaxHP;
            easyEnemy.damage = staticData.easyEnemyDamage;
            easyEnemy.isCoinCanInstantiate = true;
            easyEnemy.timeToAttack = staticData.enemyAttackTime;
            easyEnemyGO.SetActive(false);

            runtimeData.round3Enemies.Add(easyEnemyEntity);
        }
        else if (round_num == 4)
        {
            EcsEntity easyEnemyEntity = ecsWorld.NewEntity();
            ref var easyEnemy = ref easyEnemyEntity.Get<EasyEnemy>();

            GameObject easyEnemyGO = Object.Instantiate(staticData.enemyPrefab, sceneData.easyEnemyRound4SpawnPoints[runtimeData.round4Enemies.Count].position, Quaternion.identity);
            easyEnemy.easyEnemyRb = easyEnemyGO.GetComponent<Rigidbody2D>();
            easyEnemy.easyEnemyGO = easyEnemyGO.gameObject;
            easyEnemy._transform = easyEnemyGO.GetComponent<Transform>();
            easyEnemy.startPos = easyEnemyGO.transform.position;
            easyEnemy.easyEnemyMoveSpeed = staticData.easyEnemyMoveSpeed;
            triggerCheck = easyEnemyGO.GetComponent<EnemyTriggerCheck>();
            easyEnemy.enemyTriggerCheck = triggerCheck;
            easyEnemy.MaxHP = staticData.easyEnemyMaxHP;
            easyEnemy.HP = easyEnemy.MaxHP;
            easyEnemy.damage = staticData.easyEnemyDamage;
            easyEnemy.isCoinCanInstantiate = true;
            easyEnemy.timeToAttack = staticData.enemyAttackTime;
            easyEnemyGO.SetActive(false);

            runtimeData.round4Enemies.Add(easyEnemyEntity);
        }
        else if (round_num == 5)
        {
            EcsEntity easyEnemyEntity = ecsWorld.NewEntity();
            ref var easyEnemy = ref easyEnemyEntity.Get<EasyEnemy>();

            GameObject easyEnemyGO = Object.Instantiate(staticData.enemyPrefab, sceneData.easyEnemyRound5SpawnPoints[runtimeData.round5Enemies.Count].position, Quaternion.identity);
            easyEnemy.easyEnemyRb = easyEnemyGO.GetComponent<Rigidbody2D>();
            easyEnemy.easyEnemyGO = easyEnemyGO.gameObject;
            easyEnemy._transform = easyEnemyGO.GetComponent<Transform>();
            easyEnemy.startPos = easyEnemyGO.transform.position;
            easyEnemy.easyEnemyMoveSpeed = staticData.easyEnemyMoveSpeed;
            triggerCheck = easyEnemyGO.GetComponent<EnemyTriggerCheck>();
            easyEnemy.enemyTriggerCheck = triggerCheck;
            easyEnemy.MaxHP = staticData.easyEnemyMaxHP;
            easyEnemy.HP = easyEnemy.MaxHP;
            easyEnemy.damage = staticData.easyEnemyDamage;
            easyEnemy.isCoinCanInstantiate = true;
            easyEnemy.timeToAttack = staticData.enemyAttackTime;
            easyEnemyGO.SetActive(false);

            runtimeData.round5Enemies.Add(easyEnemyEntity);
        }
    }
}
