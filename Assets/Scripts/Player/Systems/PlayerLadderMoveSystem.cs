using Leopotam.Ecs;
using UnityEngine;

public class PlayerLadderMoveSystem : IEcsRunSystem
{
    private EcsFilter<Player, PlayerInputData> filter;
    public void Run()
    {
        ref var player = ref filter.Get1(0);
        ref var input = ref filter.Get2(0);

        if (player.playerLadderCheck.isOnLadder)
        {
            player.rb.isKinematic = true;

            player.rb.velocity = new Vector2(player.rb.velocity.x, input.moveInput.y * player.moveSpeed);
        }
        else
        {
            player.rb.isKinematic = false;
        }
    }
}
