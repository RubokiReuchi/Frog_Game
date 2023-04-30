using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box3 : MonoBehaviour
{
    Animator anim;
    public float hp = 4;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.CompareTag("Player") && PlayerMove.attacking == true) || (collision.CompareTag("Player2") && Player2Move.attacking == true))
        {
            if (hp > 1)
            {
                anim.Play("Hit");
                hp--;
            }
            else
            {
                anim.Play("Break");
                Destroy(gameObject, 0.5f);
            }
        }
    }
}
