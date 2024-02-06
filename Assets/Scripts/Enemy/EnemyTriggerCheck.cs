using UnityEngine;

public class EnemyTriggerCheck : MonoBehaviour
{
    public bool isAttackedBySword = false;
    public bool isAttackedBySwordBullet = false;
    public bool isAttackedByGunStoneBullet = false;
    public bool isAttackedByGunArrowBullet = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sword"))
        {
            isAttackedBySword = true;
        }
        if (collision.CompareTag("SwordBullet"))
        {
            isAttackedBySwordBullet = true;
        }
        if (collision.CompareTag("GunStoneBullet"))
        {
            isAttackedByGunStoneBullet = true;
        }
        if (collision.CompareTag("GunArrowBullet"))
        {
            isAttackedByGunArrowBullet = true;
        }
    }
}
