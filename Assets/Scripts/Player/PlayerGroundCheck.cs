using Leopotam.Ecs;
using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    public bool isGrounded;
    public bool isArenaGrounded;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") || collision.CompareTag("ArenaGround"))
        {
            isGrounded = true;
        }
        if (collision.CompareTag("ArenaGround"))
        {
            isArenaGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") || collision.CompareTag("ArenaGround"))
        {
            isGrounded = false;
        }
        if (collision.CompareTag("ArenaGround"))
        {
            isArenaGrounded = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") || collision.CompareTag("ArenaGround"))
        {
            isGrounded = true;
        }
    }
}
