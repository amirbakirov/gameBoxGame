using Leopotam.Ecs;
using UnityEngine;

public class PlayerAttackSystem : IEcsRunSystem
{
    private StaticData staticData;
    private EcsFilter<Player, PlayerInputData, WeaponsWithBullet> filter;
    public void Run()
    {
        ref var player = ref filter.Get1(0);
        ref var input = ref filter.Get2(0);
        ref var weaponsWithBullet = ref filter.Get3(0);
        if (input.isAttack)
        {
            input.isAttack = false;

            if (player.isSwordNow)
            {
                if (player.anim.GetCurrentAnimatorStateInfo(0).IsName("Default"))
                {
                    player.anim.Play("Sword" + player.swordIndexNow);
                    if (player.swordIndexNow == 3)
                    {
                        weaponsWithBullet.isSword3CanShoot = true;
                    }
                }
            }
            else
            {
                if (player.anim.GetCurrentAnimatorStateInfo(0).IsName("Default"))
                {
                    player.anim.Play("Gun" + player.gunIndexNow);
                    if (player.gunIndexNow == 1)
                    {
                        weaponsWithBullet.isGun1CanShoot = true;
                    }
                    else if (player.gunIndexNow == 2)
                    {
                        weaponsWithBullet.isGun2CanShoot = true;
                    }
                    else if (player.gunIndexNow == 3)
                    {
                        weaponsWithBullet.isGun3CanShoot = true;
                    }
                }
            }
        }

        if (player.anim.GetCurrentAnimatorStateInfo(0).IsName("Sword3"))
        {
            if (staticData.sword3BulletSpawnPoint.isCanShoot && weaponsWithBullet.isSword3CanShoot)
            {
                weaponsWithBullet.isSword3CanShoot = false;
                GameObject stoneBullet = StoneInstantiate(staticData.sword3BulletSpawnPoint.transform.position);
                stoneBullet.tag = "SwordBullet";
            }
        }
        else if (!player.anim.GetCurrentAnimatorStateInfo(0).IsName("Default"))
        {
            if (player.gunIndexNow == 1)
            {
                if (staticData.gun1BulletSpawnPoint.isCanShoot && weaponsWithBullet.isGun1CanShoot)
                {
                    weaponsWithBullet.isGun1CanShoot = false;
                    GameObject stoneBullet = StoneInstantiate(staticData.gun1BulletSpawnPoint.transform.position);
                    stoneBullet.tag = "GunStoneBullet";
                }
            }
            else if (player.gunIndexNow == 2)
            {
                if (staticData.gun2BulletSpawnPoint.isCanShoot && weaponsWithBullet.isGun2CanShoot)
                {
                    weaponsWithBullet.isGun2CanShoot = false;
                    GameObject arrowBullet = ArrowInstantiate(staticData.gun2BulletSpawnPoint.transform.position);
                    arrowBullet.tag = "GunArrowBullet";
                
                }
            }
            else if (player.gunIndexNow == 3)
            {
                if (staticData.gun3BulletSpawnPoint.isCanShoot && weaponsWithBullet.isGun3CanShoot)
                {
                    weaponsWithBullet.isGun3CanShoot = false;
                    GameObject arrowBullet = ArrowInstantiate(staticData.gun3BulletSpawnPoint.transform.position);
                    arrowBullet.tag = "GunArrowBullet";
                }
            }
        }
    }

    public GameObject StoneInstantiate(Vector2 pos)
    {
        GameObject stoneBullet = Object.Instantiate(staticData.stoneSlingshot, pos, Quaternion.identity);

        Rigidbody2D rb = stoneBullet.GetComponent<Rigidbody2D>();

        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - stoneBullet.transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        stoneBullet.transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);

        ref var player = ref filter.Get1(0);
        rb.velocity = stoneBullet.transform.right * player.moveSpeed * 2;

        Object.Destroy(stoneBullet, 10);
        return stoneBullet;
    }
    public GameObject ArrowInstantiate(Vector2 pos)
    {
        GameObject arrowBullet = Object.Instantiate(staticData.Arrow, pos, Quaternion.identity);

        Rigidbody2D rb = arrowBullet.GetComponent<Rigidbody2D>();

        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - arrowBullet.transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        arrowBullet.transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);

        ref var player = ref filter.Get1(0);
        rb.velocity = arrowBullet.transform.right * player.moveSpeed * 2;

        Object.Destroy(arrowBullet, 10);
        return arrowBullet;
    }
}
