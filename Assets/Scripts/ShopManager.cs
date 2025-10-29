using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;

    public List<Unit> unitList;
    public GameObject shop;

    public int coins;

    Image unitSprite; 
    string unitDescription;

    public TMP_Text coinsText;

    public GameObject unit1Panel;
    public GameObject unit2Panel;
    public GameObject unit3Panel;

    public Image unit1Image;
    public TMP_Text unit1Description;
    public Image unit2Image;
    public TMP_Text unit2Description;
    public Image unit3Image;
    public TMP_Text unit3Description;

    Unit unit1;
    Unit unit2;
    Unit unit3;

    List<Sprite> yourUnitSprites; 
    public TMP_Text currentFloor;

    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        EnableShop();
    }

    public void BuyUnit1()
    {
        if(!AbleToUseCoin(3)) return;
        unit1Panel.SetActive(false);
        MyUnitManager.instance.AddUnit(unit1);

    }

    public void BuyUnit2()
    {
        if(!AbleToUseCoin(3)) return;
        unit2Panel.SetActive(false);
        MyUnitManager.instance.AddUnit(unit2);

    }

    public void BuyUnit3()
    {
        if(!AbleToUseCoin(3)) return;
        unit3Panel.SetActive(false);
        MyUnitManager.instance.AddUnit(unit3);

    }

    public void Reroll()
    {
        if(!AbleToUseCoin(2)) return;
        ActivateAllUnitPanels();

        string hp, atk, atkCd, range;

        int x = Random.Range(0, unitList.Count);
        unit1 = unitList[x];
        hp = unit1.maxHealth.ToString();
        atk = unit1.attackDamage.ToString();
        atkCd = unit1.attackInterval.ToString();
        range = unit1.attackRange.ToString();
        unit1Image.sprite = unit1.GetComponent<SpriteRenderer>().sprite;
        unit1Description.text = "HP: " + hp + "\nATK: " + atk + "\nATK CD: " + atkCd + "\nRange: " + range;
        
        x = Random.Range(0, unitList.Count);
        unit2 = unitList[x];
        hp = unit2.maxHealth.ToString();
        atk = unit2.attackDamage.ToString();
        atkCd = unit2.attackInterval.ToString();
        range = unit2.attackRange.ToString();
        unit2Image.sprite = unit2.GetComponent<SpriteRenderer>().sprite;
        unit2Description.text = "HP: " + hp + "\nATK: " + atk + "\nATK CD: " + atkCd + "\nRange: " + range;

        x = Random.Range(0, unitList.Count);
        unit3 = unitList[x];
        hp = unit3.maxHealth.ToString();
        atk = unit3.attackDamage.ToString();
        atkCd = unit3.attackInterval.ToString();
        range = unit3.attackRange.ToString();
        unit3Image.sprite = unit3.GetComponent<SpriteRenderer>().sprite;
        unit3Description.text = "HP: " + hp + "\nATK: " + atk + "\nATK CD: " + atkCd + "\nRange: " + range;
    }

    public void UpdateCoinValue()
    {
        coinsText.text = "Coins: " + coins.ToString();
    }

    public void ActivateAllUnitPanels()
    {
        unit1Panel.SetActive(true);
        unit2Panel.SetActive(true);
        unit3Panel.SetActive(true);
    }

    public void EnableShop()
    {
        currentFloor.text = "";
        coins = 12;
        Reroll();
        UpdateCoinValue();
        shop.SetActive(true);
    }

    public void DisableShop()
    {
        shop.SetActive(false);
        currentFloor.text = "Floor " + GameManager.instance.currentLevel;
    }

    bool AbleToUseCoin(int amount)
    {
        if (coins-amount >= 0) 
        {
            coins -= amount;
            UpdateCoinValue();
            return true;
        }
        else return false;        
    }
}
