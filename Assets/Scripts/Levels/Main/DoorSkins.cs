using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorSkins : MonoBehaviour
{
    public GameObject psScript;
    public GameObject skinsPanel;
    public GameObject p1;
    public GameObject p2;
    private bool inDoor1 = false;
    private bool inDoor2 = false;
    private int skinColor1 = 0;
    private int skinColor2 = 1;

    private void Start()
    {
        //Player 1
        switch (PlayerPrefs.GetString("Skin1"))
        {
            case "Green":
                skinColor1 = 0;
                break;
            case "Red":
                skinColor1 = 1;
                break;
            case "Brown":
                skinColor1 = 2;
                break;
            case "Yellow":
                skinColor1 = 3;
                break;
            default:
                break;
        }

        //Player 2
        switch (PlayerPrefs.GetString("Skin2"))
        {
            case "Green":
                skinColor2 = 0;
                break;
            case "Red":
                skinColor2 = 1;
                break;
            case "Brown":
                skinColor2 = 2;
                break;
            case "Yellow":
                skinColor2 = 3;
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        //Player 1
        if (inDoor1)
        {
            if (Input.GetKeyDown("0"))
            {
                if (skinColor2 != 0)
                {
                    skinColor1 = 0;
                }
            }
            else if (Input.GetKeyDown("1"))
            {
                if (skinColor2 != 1)
                {
                    skinColor1 = 1;
                }
            }
            else if (Input.GetKeyDown("2"))
            {
                if (skinColor2 != 2)
                {
                    skinColor1 = 2;
                }
            }
            else if (Input.GetKeyDown("3"))
            {
                if (skinColor2 != 3)
                {
                    skinColor1 = 3;
                }
            }
        }

        //Player2
        if (inDoor2)
        {
            if (Input.GetKeyDown("[0]"))
            {
                if (skinColor1 != 0)
                {
                    skinColor2 = 0;
                }
            }
            else if (Input.GetKeyDown("[1]"))
            {
                if (skinColor1 != 1)
                {
                    skinColor2 = 1;
                }
            }
            else if (Input.GetKeyDown("[2]"))
            {
                if (skinColor1 != 2)
                {
                    skinColor2 = 2;
                }
            }
            else if (Input.GetKeyDown("[3]"))
            {
                if (skinColor1 != 3)
                {
                    skinColor2 = 3;
                }
            }
        }

        if (inDoor1 || inDoor2)
        {
            skinsPanel.SetActive(true);

            if (inDoor1)
            {
                switch (skinColor1)
                {
                    case 0:
                        psScript.GetComponent<PlayerSelect>().ChangeSkin1("Green");
                        PlayerPrefs.SetString("Skin1", "Green");
                        break;
                    case 1:
                        psScript.GetComponent<PlayerSelect>().ChangeSkin1("Red");
                        PlayerPrefs.SetString("Skin1", "Red");
                        break;
                    case 2:
                        psScript.GetComponent<PlayerSelect>().ChangeSkin1("Brown");
                        PlayerPrefs.SetString("Skin1", "Brown");
                        break;
                    case 3:
                        psScript.GetComponent<PlayerSelect>().ChangeSkin1("Yellow");
                        PlayerPrefs.SetString("Skin1", "Yellow");
                        break;
                    default:
                        break;
                }
            }
            
            if (inDoor2)
            {
                switch (skinColor2)
                {
                    case 0:
                        psScript.GetComponent<PlayerSelect>().ChangeSkin2("Green");
                        PlayerPrefs.SetString("Skin2", "Green");
                        break;
                    case 1:
                        psScript.GetComponent<PlayerSelect>().ChangeSkin2("Red");
                        PlayerPrefs.SetString("Skin2", "Red");
                        break;
                    case 2:
                        psScript.GetComponent<PlayerSelect>().ChangeSkin2("Brown");
                        PlayerPrefs.SetString("Skin2", "Brown");
                        break;
                    case 3:
                        psScript.GetComponent<PlayerSelect>().ChangeSkin2("Yellow");
                        PlayerPrefs.SetString("Skin2", "Yellow");
                        break;
                    default:
                        break;
                }
            }
        }
        else
        {
            skinsPanel.SetActive(false);
        }

        //Player 1
        switch (PlayerPrefs.GetString("Skin1"))
        {
            case "Green":
                p1.transform.localPosition = new Vector3(-295f, p1.transform.localPosition.y, 0f);
                break;
            case "Red":
                p1.transform.localPosition = new Vector3(-95f, p1.transform.localPosition.y, 0f);
                break;
            case "Brown":
                p1.transform.localPosition = new Vector3(105f, p1.transform.localPosition.y, 0f);
                break;
            case "Yellow":
                p1.transform.localPosition = new Vector3(305f, p1.transform.localPosition.y, 0f);
                break;
            default:
                break;
        }

        //Player 2
        switch (PlayerPrefs.GetString("Skin2"))
        {
            case "Green":
                p2.transform.localPosition = new Vector3(-295f, p2.transform.localPosition.y, 0f);
                break;
            case "Red":
                p2.transform.localPosition = new Vector3(-95f, p2.transform.localPosition.y, 0f);
                break;
            case "Brown":
                p2.transform.localPosition = new Vector3(105f, p2.transform.localPosition.y, 0f);
                break;
            case "Yellow":
                p2.transform.localPosition = new Vector3(305f, p2.transform.localPosition.y, 0f);
                break;
            default:
                break;
        }
    }

    //inDoor true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inDoor1 = true;
        }
        if (collision.CompareTag("Player2"))
        {
            inDoor2 = true;
        }
    }

    //inDoor false
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inDoor1 = false;
        }
        if (collision.CompareTag("Player2"))
        {
            inDoor2 = false;
        }
    }
}
