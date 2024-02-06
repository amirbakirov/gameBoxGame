using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player") && !collision.CompareTag("GroundCheck") &&
            !collision.CompareTag("Sword") && !collision.CompareTag("Coin") && !collision.CompareTag("Ladder"))
            Destroy(gameObject);
    }
}
