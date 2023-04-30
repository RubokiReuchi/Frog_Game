using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public GameObject transition;
    public Text fruitText;

    private void Update()
    {
        AllFruitsCollected();
        fruitText.text = transform.childCount.ToString();
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            transition.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
