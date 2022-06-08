using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isCollided = false;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    //oncollision tetiklendiðinde bir defa çalýþýr
    private void OnCollisionEnter(Collision block)
    {
        if (isCollided == false)
        {
            print(block.gameObject.name);
            GetComponent<MeshRenderer>().material.color = Color.red;
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score--;
            isCollided = true;
        }

    }
}
