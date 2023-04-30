using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuTP : MonoBehaviour
{
    public Text text;
    public string levelName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Player2"))
        {
            text.gameObject.SetActive(true);

            if ((collision.CompareTag("Player") && PlayerMove.attacking == true) || (collision.CompareTag("Player2") && Player2Move.attacking == true))
            {
                SceneManager.LoadScene(levelName);
            }
        }
        else
        {
            text.gameObject.SetActive(false);
        }
    }
}