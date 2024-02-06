using Leopotam.Ecs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUpgradeSystem : IEcsInitSystem, IEcsRunSystem
{
    private SceneData sceneData;
    private EcsFilter<Player> playerFilter;
    public void Init()
    {
        sceneData.upgradeSword1Panel.SetActive(true);
        sceneData.upgradeSword2Panel.SetActive(false);
        sceneData.upgradeSword3Panel.SetActive(false);
        sceneData.upgradeGun1Panel.SetActive(true);
        sceneData.upgradeGun2Panel.SetActive(false);
        sceneData.upgradeGun3Panel.SetActive(false);


        sword1UpgradeButton1();
        sword1UpgradeButton2();
        sword1UpgradeButton3();
        sword2UpgradeButton1();
        sword2UpgradeButton2();
        sword2UpgradeButton3();
        sword3UpgradeButton1();
        sword3UpgradeButton2();

        gun1UpgradeButton1();
        gun1UpgradeButton2();
        gun1UpgradeButton3();
        gun1UpgradeButton4();
        gun2UpgradeButton1();
        gun2UpgradeButton2();
        gun2UpgradeButton3();
        gun3UpgradeButton1();
        gun3UpgradeButton2();

        playerUpgradeButton1();
        playerUpgradeButton2();
        playerUpgradeButton3();


        // sword upgrade buttons
        foreach (Button i in sceneData.sword1UpgradeButtons)
        {
            i.interactable = false;
            i.onClick.AddListener(() =>
            {
                ref var player = ref playerFilter.Get1(0);
                TMP_Text tmp_text = i.transform.GetChild(0).GetComponent<TMP_Text>();
                int needCoins = -1;
                try
                {
                    needCoins = int.Parse(tmp_text.text);
                }
                catch (System.Exception)
                {
                    needCoins = CoinParser(tmp_text.text);
                }
                if (player.coins >= needCoins)
                {
                    player.coins -= needCoins;
                    tmp_text.text = "готово";
                    i.interactable = false;
                }
            });
        }
        sceneData.sword1UpgradeButtons[0].interactable = true;

        foreach (Button i in sceneData.sword2UpgradeButtons)
        {
            i.interactable = false;
            i.onClick.AddListener(() =>
            {
                ref var player = ref playerFilter.Get1(0);
                TMP_Text tmp_text = i.transform.GetChild(0).GetComponent<TMP_Text>();
                int needCoins = -1;
                try
                {
                    needCoins = int.Parse(tmp_text.text);
                }
                catch (System.Exception)
                {
                    needCoins = CoinParser(tmp_text.text);
                }
                if (player.coins >= needCoins)
                {
                    player.coins -= needCoins;
                    tmp_text.text = "готово";
                    i.interactable = false;
                }
            });
        }
        sceneData.sword2UpgradeButtons[0].interactable = true;

        foreach (Button i in sceneData.sword3UpgradeButtons)
        {
            i.interactable = false;
            i.onClick.AddListener(() =>
            {
                ref var player = ref playerFilter.Get1(0);
                TMP_Text tmp_text = i.transform.GetChild(0).GetComponent<TMP_Text>();
                int needCoins = -1;
                try
                {
                    needCoins = int.Parse(tmp_text.text);
                }
                catch (System.Exception)
                {
                    needCoins = CoinParser(tmp_text.text);
                }
                if (player.coins >= needCoins)
                {
                    player.coins -= needCoins;
                    tmp_text.text = "готово";
                    i.interactable = false;
                }
            });
        }
        sceneData.sword3UpgradeButtons[0].interactable = true;


        // gun upgrade buttons
        foreach (Button i in sceneData.gun1UpgradeButtons)
        {
            i.interactable = false;
            i.onClick.AddListener(() =>
            {
                ref var player = ref playerFilter.Get1(0);
                TMP_Text tmp_text = i.transform.GetChild(0).GetComponent<TMP_Text>();
                int needCoins = -1;
                try
                {
                    needCoins = int.Parse(tmp_text.text);
                }
                catch (System.Exception)
                {
                    needCoins = CoinParser(tmp_text.text);
                }
                if (player.coins >= needCoins)
                {
                    player.coins -= needCoins;
                    tmp_text.text = "готово";
                    i.interactable = false;
                }
            });
        }
        sceneData.gun1UpgradeButtons[0].interactable = true;

        foreach (Button i in sceneData.gun2UpgradeButtons)
        {
            i.interactable = false;
            i.onClick.AddListener(() =>
            {
                ref var player = ref playerFilter.Get1(0);
                TMP_Text tmp_text = i.transform.GetChild(0).GetComponent<TMP_Text>();
                int needCoins = -1;
                try
                {
                    needCoins = int.Parse(tmp_text.text);
                }
                catch (System.Exception)
                {
                    needCoins = CoinParser(tmp_text.text);
                }
                if (player.coins >= needCoins)
                {
                    player.coins -= needCoins;
                    tmp_text.text = "готово";
                    i.interactable = false;
                }
            });
        }
        sceneData.gun2UpgradeButtons[0].interactable = true;

        foreach (Button i in sceneData.gun3UpgradeButtons)
        {
            i.interactable = false;
            i.onClick.AddListener(() =>
            {
                ref var player = ref playerFilter.Get1(0);
                TMP_Text tmp_text = i.transform.GetChild(0).GetComponent<TMP_Text>();
                int needCoins = -1;
                try
                {
                    needCoins = int.Parse(tmp_text.text);
                }
                catch (System.Exception)
                {
                    needCoins = CoinParser(tmp_text.text);
                }
                if (player.coins >= needCoins)
                {
                    player.coins -= needCoins;
                    tmp_text.text = "готово";
                    i.interactable = false;
                }
            });
        }
        sceneData.gun3UpgradeButtons[0].interactable = true;


        // player upgrade buttons
        foreach (Button i in sceneData.playerUpgradeButtons)
        {
            i.interactable = true;
            i.onClick.AddListener(() =>
            {
                ref var player = ref playerFilter.Get1(0);
                TMP_Text tmp_text = i.transform.GetChild(0).GetComponent<TMP_Text>();
                int needCoins = -1;
                try
                {
                    needCoins = int.Parse(tmp_text.text);
                }
                catch (System.Exception)
                {
                    needCoins = CoinParser(tmp_text.text);
                }
                if (player.coins >= needCoins)
                {
                    player.coins -= needCoins;
                    tmp_text.text = ConvertCoins(needCoins + 50);
                }
            });
        }
    }
    public void Run()
    {
        for (int i = 1; i < sceneData.sword1UpgradeButtons.Length; i++)
        {
            if (sceneData.sword1UpgradeButtons[i - 1].transform.GetChild(0).GetComponent<TMP_Text>().text == "готово" &&
                sceneData.sword1UpgradeButtons[i].transform.GetChild(0).GetComponent<TMP_Text>().text != "готово")
            {
                sceneData.sword1UpgradeButtons[i].interactable = true;
            }
        }
        for (int i = 1; i < sceneData.sword2UpgradeButtons.Length; i++)
        {
            if (sceneData.sword2UpgradeButtons[i - 1].transform.GetChild(0).GetComponent<TMP_Text>().text == "готово" &&
                sceneData.sword2UpgradeButtons[i].transform.GetChild(0).GetComponent<TMP_Text>().text != "готово")
            {
                sceneData.sword2UpgradeButtons[i].interactable = true;
            }
        }
        for (int i = 1; i < sceneData.sword3UpgradeButtons.Length; i++)
        {
            if (sceneData.sword3UpgradeButtons[i - 1].transform.GetChild(0).GetComponent<TMP_Text>().text == "готово" &&
                sceneData.sword3UpgradeButtons[i].transform.GetChild(0).GetComponent<TMP_Text>().text != "готово")
            {
                sceneData.sword3UpgradeButtons[i].interactable = true;
            }
        }

        for (int i = 1; i < sceneData.gun1UpgradeButtons.Length; i++)
        {
            if (sceneData.gun1UpgradeButtons[i - 1].transform.GetChild(0).GetComponent<TMP_Text>().text == "готово" &&
                sceneData.gun1UpgradeButtons[i].transform.GetChild(0).GetComponent<TMP_Text>().text != "готово")
            {
                sceneData.gun1UpgradeButtons[i].interactable = true;
            }
        }
        for (int i = 1; i < sceneData.gun2UpgradeButtons.Length; i++)
        {
            if (sceneData.gun2UpgradeButtons[i - 1].transform.GetChild(0).GetComponent<TMP_Text>().text == "готово" &&
                sceneData.gun2UpgradeButtons[i].transform.GetChild(0).GetComponent<TMP_Text>().text != "готово")
            {
                sceneData.gun2UpgradeButtons[i].interactable = true;
            }
        }
        for (int i = 1; i < sceneData.gun3UpgradeButtons.Length; i++)
        {
            if (sceneData.gun3UpgradeButtons[i - 1].transform.GetChild(0).GetComponent<TMP_Text>().text == "готово" &&
                sceneData.gun3UpgradeButtons[i].transform.GetChild(0).GetComponent<TMP_Text>().text != "готово")
            {
                sceneData.gun3UpgradeButtons[i].interactable = true;
            }
        }

        ref var player = ref playerFilter.Get1(0);
        if (player.moveSpeed >= 20)
        {
            sceneData.playerUpgradeButtons[1].interactable = false;
            sceneData.playerUpgradeButtons[1].transform.GetChild(0).GetComponent<TMP_Text>().text = "макс.";
        }
    }

    private void sword1UpgradeButton1() // damage
    {
        sceneData.sword1UpgradeButtons[0].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.sword1UpgradeButtons[0].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.swordDamage += player.swordDamage * 0.25f;
            }
        });
    }
    private void sword1UpgradeButton2() // attack speed
    {
        sceneData.sword1UpgradeButtons[1].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.sword1UpgradeButtons[1].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.anim.SetFloat("Sword1Speed", player.anim.GetFloat("Sword1Speed") * 1.1f);
            }
        });
    }
    private void sword1UpgradeButton3() // new sword
    {
        sceneData.sword1UpgradeButtons[2].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.sword1UpgradeButtons[2].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.swordIndexNow++;
                player.swordDamage *= 2;

                sceneData.upgradeSword1Panel.SetActive(false);
                sceneData.upgradeSword2Panel.SetActive(true);
            }
        });
    }

    private void sword2UpgradeButton1() // damage
    {
        sceneData.sword2UpgradeButtons[0].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.sword2UpgradeButtons[0].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.swordDamage += player.swordDamage * 0.5f;
            }
        });
    }
    private void sword2UpgradeButton2() // attack speed
    {
        sceneData.sword2UpgradeButtons[1].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.sword2UpgradeButtons[1].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.anim.SetFloat("Sword2Speed", player.anim.GetFloat("Sword2Speed") * 1.3f);
            }
        });
    }
    private void sword2UpgradeButton3() // new sword
    {
        sceneData.sword2UpgradeButtons[2].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.sword2UpgradeButtons[2].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.swordIndexNow++;
                player.swordDamage *= 2;

                sceneData.upgradeSword2Panel.SetActive(false);
                sceneData.upgradeSword3Panel.SetActive(true);
            }
        });
    }

    private void sword3UpgradeButton1() // damage
    {
        sceneData.sword3UpgradeButtons[0].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.sword3UpgradeButtons[0].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.swordDamage += player.swordDamage;
            }
        });
    }
    private void sword3UpgradeButton2() // attack speed
    {
        sceneData.sword3UpgradeButtons[1].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.sword3UpgradeButtons[1].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.anim.SetFloat("Sword3Speed", player.anim.GetFloat("Sword3Speed") * 1.5f);
            }
        });
    }



    private void gun1UpgradeButton1() // new gun
    {
        sceneData.gun1UpgradeButtons[0].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.gun1UpgradeButtons[0].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.gunIndexNow = 1;
            }
        });
    }
    private void gun1UpgradeButton2() // damage
    {
        sceneData.gun1UpgradeButtons[1].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.gun1UpgradeButtons[1].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.gunDamage += player.gunDamage * 0.25f;
            }
        });
    }
    private void gun1UpgradeButton3() // attack speed
    {
        sceneData.gun1UpgradeButtons[2].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.gun1UpgradeButtons[2].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.anim.SetFloat("Gun1Speed", player.anim.GetFloat("Gun1Speed") * 1.1f);
            }
        });
    }
    private void gun1UpgradeButton4() // new gun
    {
        sceneData.gun1UpgradeButtons[3].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.gun1UpgradeButtons[3].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.gunIndexNow++;
                player.gunDamage *= 2;

                sceneData.upgradeGun1Panel.SetActive(false);
                sceneData.upgradeGun2Panel.SetActive(true);
            }
        });
    }

    private void gun2UpgradeButton1() // damage
    {
        sceneData.gun2UpgradeButtons[0].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.gun2UpgradeButtons[0].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.gunDamage += player.gunDamage * 0.5f;
            }
        });
    }
    private void gun2UpgradeButton2() // attack speed
    {
        sceneData.gun2UpgradeButtons[1].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.gun2UpgradeButtons[1].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.anim.SetFloat("Gun2Speed", player.anim.GetFloat("Gun2Speed") * 1.3f);
            }
        });
    }
    private void gun2UpgradeButton3() // new gun
    {
        sceneData.gun2UpgradeButtons[2].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.gun2UpgradeButtons[2].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.gunIndexNow++;
                player.gunDamage *= 2;

                sceneData.upgradeGun2Panel.SetActive(false);
                sceneData.upgradeGun3Panel.SetActive(true);
            }
        });
    }

    private void gun3UpgradeButton1() // damage
    {
        sceneData.gun3UpgradeButtons[0].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.gun3UpgradeButtons[0].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.gunDamage += player.gunDamage * 0.5f;
            }
        });
    }
    private void gun3UpgradeButton2() // attack speed
    {
        sceneData.gun3UpgradeButtons[1].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.gun3UpgradeButtons[1].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.anim.SetFloat("Gun3Speed", player.anim.GetFloat("Gun3Speed") * 1.3f);
            }
        });
    }

    
    private void playerUpgradeButton1() // maxHP + 15
    {
        sceneData.playerUpgradeButtons[0].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.playerUpgradeButtons[0].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.maxHP += 15;
                player.HP = player.maxHP;
            }
        });
    }
    private void playerUpgradeButton2() // move speed +10%
    {
        sceneData.playerUpgradeButtons[1].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.playerUpgradeButtons[1].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.moveSpeed *= 1.1f;
            }
        });
    }
    private void playerUpgradeButton3() // move speed +10%
    {
        sceneData.playerUpgradeButtons[2].onClick.AddListener(() =>
        {
            ref var player = ref playerFilter.Get1(0);
            TMP_Text tmp_text = sceneData.playerUpgradeButtons[2].transform.GetChild(0).GetComponent<TMP_Text>();
            int needCoins = -1;
            try
            {
                needCoins = int.Parse(tmp_text.text);
            }
            catch (System.Exception)
            {
                needCoins = CoinParser(tmp_text.text);
            }
            if (player.coins >= needCoins)
            {
                player.coinsPerEnemyDeath += 10;
            }
        });
    }

    private int CoinParser(string text)
    {
        int parsedString = -1;
        if (text[text.Length - 1] == 'к')
        {
            parsedString = int.Parse(text.Split('к')[0]) * 1000;
        }
        else if (text[text.Length - 1] == 'м')
        {
            parsedString = int.Parse(text.Split('м')[0]) * 1000_000;
        }
        return parsedString;
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
