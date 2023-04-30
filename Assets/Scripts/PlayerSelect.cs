using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public RuntimeAnimatorController[] playersAnim;
    public Sprite[] playersSprite;
    
    //Player 1
    public void ChangeSkin1(string color)
    {
        switch (color)
        {
            case "Green":
                player1.GetComponent<Animator>().runtimeAnimatorController = playersAnim[0];
                player1.GetComponent<SpriteRenderer>().sprite = playersSprite[0];
                break;
            case "Red":
                player1.GetComponent<Animator>().runtimeAnimatorController = playersAnim[1];
                player1.GetComponent<SpriteRenderer>().sprite = playersSprite[1];
                break;
            case "Brown":
                player1.GetComponent<Animator>().runtimeAnimatorController = playersAnim[2];
                player1.GetComponent<SpriteRenderer>().sprite = playersSprite[2];
                break;
            case "Yellow":
                player1.GetComponent<Animator>().runtimeAnimatorController = playersAnim[3];
                player1.GetComponent<SpriteRenderer>().sprite = playersSprite[3];
                break;
            default:
                break;
        }
    }

    //Player 2
    public void ChangeSkin2(string color)
    {
        switch (color)
        {
            case "Green":
                player2.GetComponent<Animator>().runtimeAnimatorController = playersAnim[0];
                player2.GetComponent<SpriteRenderer>().sprite = playersSprite[0];
                break;
            case "Red":
                player2.GetComponent<Animator>().runtimeAnimatorController = playersAnim[1];
                player2.GetComponent<SpriteRenderer>().sprite = playersSprite[1];
                break;
            case "Brown":
                player2.GetComponent<Animator>().runtimeAnimatorController = playersAnim[2];
                player2.GetComponent<SpriteRenderer>().sprite = playersSprite[2];
                break;
            case "Yellow":
                player2.GetComponent<Animator>().runtimeAnimatorController = playersAnim[3];
                player2.GetComponent<SpriteRenderer>().sprite = playersSprite[3];
                break;
            default:
                break;
        }
    }
}