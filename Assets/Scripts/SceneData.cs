using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class SceneData : MonoBehaviour
{
    public Transform playerSpawnPoint;
    public Transform[] easyEnemyRound1SpawnPoints;
    public Transform[] easyEnemyRound2SpawnPoints;
    public Transform[] easyEnemyRound3SpawnPoints;
    public Transform[] easyEnemyRound4SpawnPoints;
    public Transform[] easyEnemyRound5SpawnPoints;
    public Camera mainCamera;


    public Image hpSlider;
    public TMP_Text hpText;
    public TMP_Text damageText;
    public TMP_Text moveSpeedText;
    public TMP_Text coinsText;
    public Image selectedSword;
    public Image selectedGun;


    public GameObject EButtonInPlayerUpgradesCanvas;

    public GameObject upgradePanel;
    public GameObject upgradeSword1Panel;
    public GameObject upgradeSword2Panel;
    public GameObject upgradeSword3Panel;
    public GameObject upgradeGun1Panel;
    public GameObject upgradeGun2Panel;
    public GameObject upgradeGun3Panel;

    public Button[] sword1UpgradeButtons;
    public Button[] sword2UpgradeButtons;
    public Button[] sword3UpgradeButtons;

    public Button[] gun1UpgradeButtons;
    public Button[] gun2UpgradeButtons;
    public Button[] gun3UpgradeButtons;

    public Button[] playerUpgradeButtons;

    public Image swordImage;
    public Image gunImage;

    public GameObject howToPlayPanel;
    public Button howToPlayOpenButton;
    public Button howToPlayCloseButton;

    public List<GameObject> coinsOnScene = new List<GameObject>();

    public Transform UpgradesDungeon;

    public GameObject ladders;

    public TMP_Text roundText;
}