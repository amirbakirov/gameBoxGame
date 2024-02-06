using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StaticData : ScriptableObject
{
    public GameObject playerPrefab;
    public GameObject coin;
    public GameObject enemyPrefab;

    public GameObject stoneSlingshot;
    public GameObject Arrow;
    public ShotSpawnPoints sword3BulletSpawnPoint;
    public ShotSpawnPoints gun1BulletSpawnPoint;
    public ShotSpawnPoints gun2BulletSpawnPoint;
    public ShotSpawnPoints gun3BulletSpawnPoint;

    public Sprite[] swordImages;
    public Sprite[] gunImages;

    public float playerMoveSpeed;
    public float playerJumpForce;
    public float playerMaxHP;
    public float playerSwordDamage;
    public float playerGunDamage;
    public int coins;
    public int coinsPerEnemyDeath;
    public float easyEnemyMoveSpeed;
    public float easyEnemyMaxHP;
    public float easyEnemyDamage;

    public float enemyAttackTime;

    public float smoothTime;
    public Vector3 followOffset;
}
