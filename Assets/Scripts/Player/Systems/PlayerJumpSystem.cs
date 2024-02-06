using Leopotam.Ecs;
using UnityEngine;

public class PlayerJumpSystem : IEcsRunSystem
{
    private EcsFilter<Player, PlayerInputData> filter;

    public void Run()
    {
        ref var player = ref filter.Get1(0);
        ref var input = ref filter.Get2(0);
            
        if (player.playerGroundCheck.isGrounded || player.playerGroundCheck.isArenaGrounded)
        {
            if (input.isJump)
            {
                player.rb.AddForce(Vector2.up * player.jumpForce, ForceMode2D.Impulse);
                input.isJump = false;
            }
        }
    }
}
