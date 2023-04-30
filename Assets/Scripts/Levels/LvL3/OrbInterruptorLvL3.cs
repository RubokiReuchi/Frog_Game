using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbInterruptorLvL3 : MonoBehaviour
{
    public GameObject spikeHead;
    private bool inTrigger = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player2"))
        {
            inTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player2"))
        {
            inTrigger = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("[7]") && inTrigger)
        {
            spikeHead.GetComponent<SpikeHeadLvL3>().Stuned();
        }
    }
}
