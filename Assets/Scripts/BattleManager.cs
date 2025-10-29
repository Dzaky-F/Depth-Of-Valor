using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;

    public List<Unit> playerTeam;
    public List<Unit> enemyTeam;

    public bool isBattleEnded = false;

    public GameObject gameOver;

    void Awake()
    {
        instance = this;
    }

    public void DestroyUnit(Unit x)
    {
        if (x.team == Team.playerTeam) 
        {
            playerTeam.Remove(x);
            if(!isBattleEnded) CheckPlayerTeam();
        }
        else 
        {
            enemyTeam.Remove(x);
            if(!isBattleEnded) CheckEnemyTeam();
        }
    }

    public void CheckPlayerTeam()
    {
        if (playerTeam.Count == 0) StartCoroutine(Lose());
    }

    public void CheckEnemyTeam()
    {
        if (enemyTeam.Count == 0) StartCoroutine(Win());
    }

    IEnumerator Win()
    {
        isBattleEnded = true;
        yield return new WaitForSeconds(1);
        ClearBattlefield();
        ShopManager.instance.EnableShop();
        yield return null;
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1);
        gameOver.SetActive(true);
        yield return null;
    }

    void ClearBattlefield()
    {
        while(playerTeam.Count > 0){
            playerTeam[0].Die();
        }
    }
}
