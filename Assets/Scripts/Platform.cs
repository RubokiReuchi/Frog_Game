using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    PlatformEffector2D pe2D;

    void Start()
    {
        pe2D = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("s") || Input.GetKeyDown("[5]"))
        {
            pe2D.rotationalOffset = 180;
            Invoke("resetOffset", 0.25f);
        }
    }

    private void resetOffset()
    {
        pe2D.rotationalOffset = 0;
    }
}
