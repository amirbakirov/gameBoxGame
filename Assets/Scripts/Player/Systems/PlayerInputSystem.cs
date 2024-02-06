using Leopotam.Ecs;
using UnityEngine;

public class PlayerInputSystem : IEcsRunSystem
{
    private SceneData sceneData;
    private EcsFilter<Player, PlayerInputData> filter;
    public void Run()
    {
        ref var player = ref filter.Get1(0);
        ref var input = ref filter.Get2(0);

        if (!sceneData.upgradePanel.activeSelf && !sceneData.howToPlayPanel.activeSelf)
        {
            float moveHor = Input.GetAxisRaw("Horizontal");
            float moveVer = Input.GetAxisRaw("Vertical");
            input.moveInput = new Vector2(moveHor, moveVer);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                input.isJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                input.isJump = false;
            }

            if (Input.GetMouseButtonDown(0))
            {
                input.isAttack = true;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                input.isAttack = false;
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                player.isSwordNow = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (player.gunIndexNow != -1)
                {
                    player.isSwordNow = false;
                }
            }
        }
        else
        {
            input.moveInput = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            input.isEButtonClicked = true;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            input.isEButtonClicked = false;
        }
    }
}