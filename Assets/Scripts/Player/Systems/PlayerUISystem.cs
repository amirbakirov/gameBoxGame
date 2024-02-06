using Leopotam.Ecs;
using UnityEngine;

public class PlayerUISystem : IEcsInitSystem, IEcsRunSystem
{
    private StaticData staticData;
    private SceneData sceneData;

    private EcsFilter<Player> filter;
    public void Init()
    {
        sceneData.howToPlayPanel.SetActive(false);
        sceneData.howToPlayOpenButton.onClick.AddListener(() =>
        {
            if (!sceneData.upgradePanel.activeSelf)
                sceneData.howToPlayPanel.SetActive(true);
        });
        sceneData.howToPlayCloseButton.onClick.AddListener(() =>
        {
            sceneData.howToPlayPanel.SetActive(false);
        });
    }
    public void Run()
    {
        ref var player = ref filter.Get1(0);

        sceneData.hpSlider.fillAmount = player.HP / player.maxHP;
        sceneData.hpText.text = System.Math.Round(player.HP, 2).ToString() + '/' + player.maxHP.ToString();
        if (player.isSwordNow)
            sceneData.damageText.text = "Урон: " + System.Math.Round(player.swordDamage, 2);
        else
            sceneData.damageText.text = "Урон: " + System.Math.Round(player.gunDamage, 2);
        sceneData.moveSpeedText.text = "Скорость: " + System.Math.Round(player.moveSpeed, 2);
        sceneData.coinsText.text = "Монеты: " + ConvertCoins(player.coins);
        
        if (player.isSwordNow)
        {
            sceneData.selectedSword.color = new Color(0, 0.78f, 0);
            sceneData.selectedGun.color = new Color(0.58f, 0, 0);
        }
        else
        {
            sceneData.selectedSword.color = new Color(0.58f, 0, 0);
            sceneData.selectedGun.color = new Color(0, 0.78f, 0);
        }

        sceneData.swordImage.sprite = staticData.swordImages[player.swordIndexNow - 1];
        if (player.gunIndexNow < 0)
        {
            sceneData.gunImage.gameObject.SetActive(false);
        }
        else
        {
            sceneData.gunImage.gameObject.SetActive(true);
            sceneData.gunImage.sprite = staticData.gunImages[player.gunIndexNow - 1];
        }
    }

    public string ConvertCoins(int coins)
    {
        if (coins >= 1000_000)
        {
            return (coins / 1000_000).ToString() + 'м';
        }
        else if (coins >= 1000)
        {
            return (coins / 1000).ToString() + 'к';
        }
        else
        {
            return coins.ToString();
        }
    }
}
