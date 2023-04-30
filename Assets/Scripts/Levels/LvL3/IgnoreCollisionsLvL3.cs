using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionsLvL3 : MonoBehaviour
{
    public GameObject cg2, spikeHead, bW, iC;

    private void Start()
    {
        Physics2D.IgnoreCollision(cg2.GetComponent<Collider2D>(), spikeHead.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg2.GetComponent<Collider2D>(), bW.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(cg2.GetComponent<Collider2D>(), iC.GetComponent<Collider2D>());
    }
}
