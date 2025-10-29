using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopUp : MonoBehaviour
{
    public TMP_Text damageAmount;

    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        transform.rotation = cam.transform.rotation;
        transform.Translate(0,1.5f,0);
        Destroy(gameObject, 1);
    }

    public void SetDamageAmount(string amount)
    {
        damageAmount.text = amount;
    }
}
