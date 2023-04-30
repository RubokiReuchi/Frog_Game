using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_Unlocked : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            FindObjectOfType<PlayerMove>().dobleJump = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            Destroy(gameObject, 0.5f);
        }
        else if (collision.CompareTag("Player2"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            FindObjectOfType<Player2Move>().dobleJump = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            Destroy(gameObject, 0.5f);
        }
    }
}
