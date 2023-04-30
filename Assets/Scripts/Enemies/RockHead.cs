using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player") || collision.transform.CompareTag("Player2"))
        {
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
        }
    }
}
