using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> enemyList;

    public static LevelManager instance;

    Quaternion rotation;
    Vector3[] playerPos = {new Vector3(-7,1,3), new Vector3(-7,1,0), new Vector3(-7,1,-3), 
                            new Vector3(-10,1,3), new Vector3(-10,1,0), new Vector3(-10,1,-3)};
    Vector3[] enemyPos = {new Vector3(5,1,3), new Vector3(5,1,0), new Vector3(5,1,-3),
                            new Vector3(8,1,3), new Vector3(8,1,0), new Vector3(8,1,-3),
                            new Vector3(11,1,3), new Vector3(11,1,0), new Vector3(11,1,-3)};

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rotation = Quaternion.Euler(66,0,0);
    }

    public void Level1()
    {
        PlacePlayerUnits();

        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[0], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[1], rotation).GetComponent<Unit>());
    }

    public void Level2()
    {
        PlacePlayerUnits();

        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[0], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[1], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[2], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[3], rotation).GetComponent<Unit>());
    }

    public void Level3()
    {
        PlacePlayerUnits();

        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[0], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[1], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[2], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[3], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[4], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[5], rotation).GetComponent<Unit>());
    }

    public void Level4()
    {
        PlacePlayerUnits();

        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[0], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[1], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[2], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[3], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[4], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[5], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[6], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[7], rotation).GetComponent<Unit>());
    }

    public void Level5()
    {
        PlacePlayerUnits();

        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[0], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[1], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[2], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[3], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[4], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[5], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[6], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[7], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[8], rotation).GetComponent<Unit>());
        BattleManager.instance.enemyTeam.Add(Instantiate(enemyList[0], enemyPos[9], rotation).GetComponent<Unit>());
    }
    
    public void PlacePlayerUnits()
    {
        for (int i = 0; i < MyUnitManager.instance.MyUnits.Count; i++) {
            BattleManager.instance.playerTeam.Add(Instantiate(MyUnitManager.instance.MyUnits[i], playerPos[i], rotation));
        }
    }
}
