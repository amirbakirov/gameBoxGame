using Leopotam.Ecs;
using UnityEngine;

public struct EasyEnemy
{
    public EnemyTriggerCheck enemyTriggerCheck;

    public Vector2 startPos;

    public GameObject easyEnemyGO;
    public Rigidbody2D easyEnemyRb;
    public Transform _transform;
    public float easyEnemyMoveSpeed;
    public float MaxHP;
    public float HP;
    public float damage;
    public float timeToAttack;
    public bool isCoinCanInstantiate;
}
