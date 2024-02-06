using Leopotam.Ecs;
using UnityEngine;

public struct Player
{
    public PlayerGroundCheck playerGroundCheck;
    public PlayerLaddersCheck playerLadderCheck;
    public PlayerCoinTriggerCatch playerCoinTriggerCheck;

    public Rigidbody2D rb;
    public Animator anim;
    public Transform _transform;
    public float moveSpeed;
    public float jumpForce;

    public float maxHP;
    public float HP;

    public string[] weapons_swords;
    public int swordIndexNow;
    public string[] weapons_guns;
    public int gunIndexNow;
    public bool isSwordNow;

    public float swordDamage;
    public float gunDamage;

    public int coins;
    public int coinsPerEnemyDeath;

    public bool isNearUpgradesDungeon;
}