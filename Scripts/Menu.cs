using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey("e"))
        {
            StartGame();
        }
        if (Input.GetKey("q"))
        {
            ExitGame();
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level01");
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("respawn");
    }
}
