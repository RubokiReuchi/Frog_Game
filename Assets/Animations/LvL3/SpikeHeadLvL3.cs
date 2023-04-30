using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeHeadLvL3 : MonoBehaviour
{
    Animator anim;
    public GameObject partSys;
    private bool delay = false;

    private void Start()
    {
        anim = GetComponentInParent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player2") && !delay)
        {
            anim.Play("SpikeHeadMoveLvL3");
            delay = true;
            Invoke("DelayOff", 1.25f);
        }
    }

    private void DelayOff()
    {
        delay = false;
        partSys.SetActive(false);
    }

    public void Stuned()
    {
        delay = true;
        partSys.SetActive(true);
        Invoke("DelayOff", 5.0f);
    }
}
