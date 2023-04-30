using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    Animator anim;
    public float hp = 3;

    void Start()
    {
        anim = GetComponentInParent<Animator>();
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
                Destroy(transform.parent.gameObject, 0.5f);
            }
        }
    }
}
