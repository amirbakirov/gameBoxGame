using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaddersCheck : MonoBehaviour
{
    public bool isOnLadder = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isOnLadder = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isOnLadder = false;
        }
    }
}
