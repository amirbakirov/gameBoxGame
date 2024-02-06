using Leopotam.Ecs;
using UnityEngine;

public class PlayerInitSystem : IEcsInitSystem
{
    private EcsWorld ecsWorld;
    private StaticData staticData;
    private SceneData sceneData;

    private PlayerGroundCheck groundCheck;
    private PlayerLaddersCheck laddersCheck;
    private PlayerCoinTriggerCatch coinTriggerCheck;
    public void Init()
    {
        EcsEntity playerEntity = ecsWorld.NewEntity();
        ref var player = ref playerEntity.Get<Player>();
        ref var inputData = ref playerEntity.Get<PlayerInputData>();
        ref var round = ref playerEntity.Get<Round>();
        ref var weaponsWithBullet = ref playerEntity.Get<WeaponsWithBullet>();

        GameObject playerGO = Object.Instantiate(staticData.playerPrefab, sceneData.playerSpawnPoint.position, Quaternion.identity);
        player.rb = playerGO.GetComponent<Rigidbody2D>();
        player.anim = playerGO.GetComponent<Animator>();
        player._transform = playerGO.GetComponent<Transform>();
        player.moveSpeed = staticData.playerMoveSpeed;
        player.jumpForce = staticData.playerJumpForce;

        player.maxHP = staticData.playerMaxHP;
        player.HP = player.maxHP;

        groundCheck = playerGO.GetComponent<PlayerGroundCheck>();
        player.playerGroundCheck = groundCheck;

        laddersCheck = playerGO.GetComponent<PlayerLaddersCheck>();
        player.playerLadderCheck = laddersCheck;

        coinTriggerCheck = playerGO.GetComponent<PlayerCoinTriggerCatch>();
        player.playerCoinTriggerCheck = coinTriggerCheck;

        player.weapons_swords = new string[] { "Sword1", "Sword2", "Sword3" };
        player.weapons_guns = new string[] { "Gun1", "Gun2", "Gun3" };
        player.swordIndexNow = 1;
        player.gunIndexNow = -1;
        player.isSwordNow = true;

        player.swordDamage = staticData.playerSwordDamage;
        player.gunDamage = staticData.playerGunDamage;

        player.coins = staticData.coins;
        player.coinsPerEnemyDeath = staticData.coinsPerEnemyDeath;

        player.isNearUpgradesDungeon = false;

        round.current_round = 0;

        weaponsWithBullet.isSword3CanShoot = false;
        weaponsWithBullet.isGun1CanShoot = false;
        weaponsWithBullet.isGun2CanShoot = false;
        weaponsWithBullet.isGun3CanShoot = false;

        staticData.sword3BulletSpawnPoint = playerGO.transform.Find("Swords").Find("Sword3").Find("ShotSpawnPoint").GetComponent<ShotSpawnPoints>();
        staticData.gun1BulletSpawnPoint = playerGO.transform.Find("Guns").Find("Slingshot").Find("ShotSpawnPoint").GetComponent<ShotSpawnPoints>();
        staticData.gun2BulletSpawnPoint = playerGO.transform.Find("Guns").Find("Bow").Find("ShotSpawnPoint").GetComponent<ShotSpawnPoints>();
        staticData.gun3BulletSpawnPoint = playerGO.transform.Find("Guns").Find("Crossbow").Find("ShotSpawnPoint").GetComponent<ShotSpawnPoints>();
    }
}