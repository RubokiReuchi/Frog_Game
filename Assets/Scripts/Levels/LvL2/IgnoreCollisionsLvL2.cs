using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionsLvL2 : MonoBehaviour
{
    public GameObject cg1, cg2, bW1, iC1;

    private void Start()
    {
        Physics2D.IgnoreCollision(cg1.GetComponent<Collider2D>(), bW1.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg2.GetComponent<Collider2D>(), bW1.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg1.GetComponent<Collider2D>(), iC1.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg2.GetComponent<Collider2D>(), iC1.GetComponent<Collider2D>());
    }
}
