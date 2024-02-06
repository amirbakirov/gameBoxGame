using Leopotam.Ecs;
using UnityEngine;

public class PlayerMoveSystem : IEcsRunSystem
{
    private EcsFilter<Player, PlayerInputData> filter;

    public void Run()
    {
        ref var player = ref filter.Get1(0);
        ref var input = ref filter.Get2(0);

        if (input.moveInput.x != 0)
            player._transform.localScale = new Vector3(input.moveInput.x, 1, 1);

        player.rb.velocity = new Vector2(input.moveInput.x * player.moveSpeed, player.rb.velocity.y);
    }
}
