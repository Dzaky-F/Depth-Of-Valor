using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarFill;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        transform.rotation = cam.transform.rotation;
    }

    // void Update()
    // {
    //     transform.rotation = cam.transform.rotation;
    // }

    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        healthBarFill.fillAmount = currentHealth / maxHealth;
    }
}
