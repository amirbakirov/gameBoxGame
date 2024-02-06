using Leopotam.Ecs;
using UnityEngine;

public class PlayerEnteringIntoUpgradesSystem : IEcsInitSystem, IEcsRunSystem
{
    private SceneData sceneData;
    private EcsFilter<Player, PlayerInputData> filter;
    public void Init()
    {
        sceneData.upgradePanel.SetActive(false);
    }
    public void Run()
    {
        ref var player = ref filter.Get1(0);
        ref var input = ref filter.Get2(0);
        if (player.isNearUpgradesDungeon)
        {
            sceneData.EButtonInPlayerUpgradesCanvas.SetActive(true);
            if (input.isEButtonClicked)
            {
                input.isEButtonClicked = false;
                if (sceneData.upgradePanel.activeSelf)
                    sceneData.upgradePanel.SetActive(false);
                else
                    sceneData.upgradePanel.SetActive(true);
            }
        }
        else
        {
            sceneData.EButtonInPlayerUpgradesCanvas.SetActive(false);
        }
    }
}
