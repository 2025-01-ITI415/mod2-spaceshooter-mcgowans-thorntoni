using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public int maxHealth, currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UI.instance.BossHealthSlider.maxValue = maxHealth;
        UI.instance.BossHealthSlider.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
