using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Don't forget this for using UI elements like sliders.

public class UI : MonoBehaviour
{
    public static UI instance; // Static instance for Singleton
    public Slider BossHealthSlider; // Assuming you have a Slider for the boss health

    public int maxHealth, currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure that the instance is assigned
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates
        }

        currentHealth = maxHealth;
        BossHealthSlider.maxValue = maxHealth;
        BossHealthSlider.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic here if needed
    }
}