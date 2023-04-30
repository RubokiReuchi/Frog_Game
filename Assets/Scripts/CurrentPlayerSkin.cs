using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentPlayerSkin : MonoBehaviour
{
    void Start()
    {
        GetComponent<PlayerSelect>().ChangeSkin1(PlayerPrefs.GetString("Skin1"));
        GetComponent<PlayerSelect>().ChangeSkin2(PlayerPrefs.GetString("Skin2"));
    }
}
