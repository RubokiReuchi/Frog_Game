using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreDoorCollision : MonoBehaviour
{
    public GameObject cg1, cg2;
    public GameObject door1, door2, door3;

    void Start()
    {
        Physics2D.IgnoreCollision(cg1.GetComponent<Collider2D>(), door1.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg1.GetComponent<Collider2D>(), door2.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg1.GetComponent<Collider2D>(), door3.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg2.GetComponent<Collider2D>(), door1.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg2.GetComponent<Collider2D>(), door2.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg2.GetComponent<Collider2D>(), door3.GetComponent<Collider2D>());
    }
}
