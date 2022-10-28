using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoReplay : MonoBehaviour
{
    float timer = 0;
    public Text info;

    void Start()
    {
        if (Data.isComplete)
        {
            info.text = "Congratulations \n  You Win!";
        }
        else
        {
            info.text = "GameOver \n You Lose!";
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            Data.isGameOver = false;
            Data.isComplete = false;
            Data.coin = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }
}
