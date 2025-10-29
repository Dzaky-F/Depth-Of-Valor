using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyUnitManager : MonoBehaviour
{
    public static MyUnitManager instance;

    public List<Unit> MyUnits;

    public Image myUnit1, myUnit2, myUnit3, myUnit4, myUnit5, myUnit6;

    void Awake()
    {
        instance = this;
    }

    public void AddUnit(Unit unit)
    {
        MyUnits.Add(unit);
        
        if (MyUnits.Count == 1) 
        {
            myUnit1.gameObject.SetActive(true);
            myUnit1.sprite = unit.GetComponent<SpriteRenderer>().sprite;
        }
        else if (MyUnits.Count == 2) 
        {
            myUnit2.gameObject.SetActive(true);
            myUnit2.sprite = unit.GetComponent<SpriteRenderer>().sprite;
        }
        else if (MyUnits.Count == 3) 
        {
            myUnit3.gameObject.SetActive(true);
            myUnit3.sprite = unit.GetComponent<SpriteRenderer>().sprite;
        }
        else if (MyUnits.Count == 4) 
        {
            myUnit4.gameObject.SetActive(true);
            myUnit4.sprite = unit.GetComponent<SpriteRenderer>().sprite;
        }
        else if (MyUnits.Count == 5) 
        {
            myUnit5.gameObject.SetActive(true);
            myUnit5.sprite = unit.GetComponent<SpriteRenderer>().sprite;
        }
        else if (MyUnits.Count == 6) 
        {
            myUnit6.gameObject.SetActive(true);
            myUnit6.sprite = unit.GetComponent<SpriteRenderer>().sprite;
        }
    }
}
