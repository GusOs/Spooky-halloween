using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesLife : MonoBehaviour
{
    // Vida del enemigo
    public int maxHealth = 25;

   // Vida actual
    public int currentHealth;

    // Referencia al slider
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = currentHealth;
    }
}
