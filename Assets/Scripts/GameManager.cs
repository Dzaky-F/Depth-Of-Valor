using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int currentLevel = 0;

    void Awake()
    {
        instance = this;
    }

    public void NextLevel()
    {
        currentLevel++;
        ShopManager.instance.DisableShop();
        BattleManager.instance.isBattleEnded = false;

        if (currentLevel == 1){
            LevelManager.instance.Level1();
        }   
        else if (currentLevel == 2){
            LevelManager.instance.Level2();
        }   
        else if (currentLevel == 3){
            LevelManager.instance.Level3();
        }
        else if (currentLevel == 4){
            LevelManager.instance.Level4();
        }   
        else if (currentLevel == 5){
            LevelManager.instance.Level5();
        }   
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
