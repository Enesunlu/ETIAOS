using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public bool gameFinished = false;
    public bool gameOver = false;
    [SerializeField] private float levelFinishTime = 5f;
    [SerializeField] private Text timeText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        UpdateTheTimer();

        if (Time.time > levelFinishTime && gameOver == false)
        {
            print(Time.time);
            gameFinished = true;
            print("GAME OVER! ^.^");
        }
        if (gameOver == true)
        {
            print("Restart");
        }

    }
    private void UpdateTheTimer()
    {
        timeText.text = "Time: " + (int)Time.time;
    }
}
