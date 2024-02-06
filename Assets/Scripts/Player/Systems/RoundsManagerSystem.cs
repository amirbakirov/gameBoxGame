using Leopotam.Ecs;
using System.Linq;
using UnityEngine;

public class RoundsManagerSystem : IEcsInitSystem, IEcsRunSystem
{
    private SceneData sceneData;
    private StaticData staticData;
    private RuntimeData runtimeData;
    private EcsFilter<Player, Round> filter;
    private EcsFilter<EasyEnemy> easyEnemyFilter;

    public void Init()
    {
        sceneData.roundText.gameObject.SetActive(false);
    }
    public void Run()
    {
        ref var player = ref filter.Get1(0);
        ref var round = ref filter.Get2(0);

        if (player.playerGroundCheck.isArenaGrounded && round.current_round == 0)
        {
            round.current_round = 1;
            ActivateEnemies(round.current_round);
            sceneData.roundText.gameObject.SetActive(true);
            sceneData.roundText.text = "Раунд 1";
        }
        if (IsNewRoundCanStart(round.current_round))
        {
            round.current_round++;
            ActivateEnemies(round.current_round);
            sceneData.roundText.text = "Раунд " + round.current_round.ToString();
        }
    }
    private bool IsNewRoundCanStart(int round_num)
    {
        if (round_num == 0) return false;
        if (round_num > 5)
        {
            ref var player = ref filter.Get1(0);
            player.HP -= player.maxHP;
            player.playerGroundCheck.isArenaGrounded = false;
            return false;
        }

        bool isCan = true;
        if (round_num == 1)
        {
            for (int i = 0; i < runtimeData.round1Enemies.Count; i++)
            {
                if (runtimeData.round1Enemies[i].Get<EasyEnemy>().easyEnemyGO.activeSelf)
                {
                    isCan = false;
                }
            }
        }
        else if (round_num == 2)
        {
            for (int i = 0; i < runtimeData.round2Enemies.Count; i++)
            {
                if (runtimeData.round2Enemies[i].Get<EasyEnemy>().easyEnemyGO.activeSelf)
                {
                    isCan = false;
                }
            }
        }
        else if (round_num == 3)
        {
            for (int i = 0; i < runtimeData.round3Enemies.Count; i++)
            {
                if (runtimeData.round3Enemies[i].Get<EasyEnemy>().easyEnemyGO.activeSelf)
                {
                    isCan = false;
                }
            }
        }
        else if (round_num == 4)
        {
            for (int i = 0; i < runtimeData.round4Enemies.Count; i++)
            {
                if (runtimeData.round4Enemies[i].Get<EasyEnemy>().easyEnemyGO.activeSelf)
                {
                    isCan = false;
                }
            }
        }
        else if (round_num == 5)
        {
            for (int i = 0; i < runtimeData.round5Enemies.Count; i++)
            {
                if (runtimeData.round5Enemies[i].Get<EasyEnemy>().easyEnemyGO.activeSelf)
                {
                    isCan = false;
                }
            }
        }
        return isCan;
    }
    private void ActivateEnemies(int round_num)
    {
        if (round_num == 1)
        {
            for (int i = 0; i < runtimeData.round1Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round1Enemies[i].Get<EasyEnemy>();
                easyEnemy.MaxHP = staticData.easyEnemyMaxHP;
                easyEnemy.HP = easyEnemy.MaxHP;
                easyEnemy._transform.position = easyEnemy.startPos;
                easyEnemy.damage = staticData.easyEnemyDamage;
                easyEnemy.isCoinCanInstantiate = true;
                easyEnemy.easyEnemyGO.SetActive(true);
            }
        }
        else if (round_num == 2)
        {
            for (int i = 0; i < runtimeData.round2Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round2Enemies[i].Get<EasyEnemy>();
                easyEnemy.MaxHP = staticData.easyEnemyMaxHP * 2f;
                easyEnemy.HP = easyEnemy.MaxHP;
                easyEnemy._transform.position = easyEnemy.startPos;
                easyEnemy.damage = staticData.easyEnemyDamage * 2f;
                easyEnemy.isCoinCanInstantiate = true;
                easyEnemy.easyEnemyGO.SetActive(true);
            }
        }
        else if (round_num == 3)
        {
            for (int i = 0; i < runtimeData.round3Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round3Enemies[i].Get<EasyEnemy>();
                easyEnemy.MaxHP = staticData.easyEnemyMaxHP * 3;
                easyEnemy.HP = easyEnemy.MaxHP;
                easyEnemy._transform.position = easyEnemy.startPos;
                easyEnemy.damage = staticData.easyEnemyDamage * 3;
                easyEnemy.isCoinCanInstantiate = true;
                easyEnemy.easyEnemyGO.SetActive(true);
            }
        }
        else if (round_num == 4)
        {
            for (int i = 0; i < runtimeData.round4Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round4Enemies[i].Get<EasyEnemy>();
                easyEnemy.MaxHP = staticData.easyEnemyMaxHP * 4;
                easyEnemy.HP = easyEnemy.MaxHP;
                easyEnemy._transform.position = easyEnemy.startPos;
                easyEnemy.damage = staticData.easyEnemyDamage * 4;
                easyEnemy.isCoinCanInstantiate = true;
                easyEnemy.easyEnemyGO.SetActive(true);
            }
        }
        else if (round_num == 5)
        {
            for (int i = 0; i < runtimeData.round5Enemies.Count; i++)
            {
                ref var easyEnemy = ref runtimeData.round5Enemies[i].Get<EasyEnemy>();
                easyEnemy.MaxHP = staticData.easyEnemyMaxHP * 5;
                easyEnemy.HP = easyEnemy.MaxHP;
                easyEnemy._transform.position = easyEnemy.startPos;
                easyEnemy.damage = staticData.easyEnemyDamage * 5;
                easyEnemy.isCoinCanInstantiate = true;
                easyEnemy.easyEnemyGO.SetActive(true);
            }
        }
    }
}
