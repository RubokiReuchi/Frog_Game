using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject optsPanel;

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (optsPanel.activeSelf == false)
            {
                Time.timeScale = 0; //Para tiempo del juego
                optsPanel.SetActive(true);
            }
            else
            {
                Return();
            }
        }
    }

    public void Return()
    {
        Time.timeScale = 1; //Seguir
        optsPanel.SetActive(false);
    }

    public void SetMenu()
    {

    }

    public void GoMenu()
    {
        Time.timeScale = 1; //Seguir
        SceneManager.LoadScene("StartMenu");
    }

    public void ExitGame()
    {
        Application.Quit(); //Solo funciona en la apk, no en el editor
    }
}
