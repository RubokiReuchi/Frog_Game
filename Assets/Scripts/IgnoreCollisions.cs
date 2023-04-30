using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisions : MonoBehaviour
{
    public GameObject player1, player2, cg1, cg2; //Players

    void Start()
    {
        //Ignore collision between Players
        Physics2D.IgnoreCollision(player1.GetComponent<Collider2D>(), player2.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg1.GetComponent<Collider2D>(), cg2.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(player1.GetComponent<Collider2D>(), cg2.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(player2.GetComponent<Collider2D>(), cg1.GetComponent<Collider2D>());
    }
}
