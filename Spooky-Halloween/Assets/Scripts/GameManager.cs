using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    //Instancia de la clase
    public static GameManager Instance;

    //Variable para comprobar que el juego está activo
    public bool isGameActive;

    //Objeto del panel wingame
    public GameObject panelWinGame;

    //Objeto panel rondas

    //Referencia a la vida de las calabazas
    private PumpkinManager pumpKinScript;


    private void Awake()
    {
        Instance = this;
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        PumpkinManager = currentHealth.GetComponent<PumpkinManager>();
        Time.timeScale = 1;
    }

    public void GameOver() 
    {
        if(PumpkinManager.currentHealth <= 0 && isGameActive) 
        {
            isGameActive = false;

        }
    }

    public void Wingame() 
    {
        if(isGameActive) 
        {
            isGameActive = false;

            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
