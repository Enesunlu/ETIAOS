using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RRRMachine : MonoBehaviour
{
    [SerializeField] private bool isInRangeRRR = false;

/*
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Girdin");
        if (collision.gameObject.tag == "Player")
        {
            isInRangeRRR = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Ciktin");
        if (collision.gameObject.tag == "Player")
        {
            isInRangeRRR = false;
        }
    }
*/

    private void OnTriggerEnter(Collider other)
    {  
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Worked!");
            isInRangeRRR = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ciktin");
            isInRangeRRR = false;
        }
    }

    private void Update()
    {
        if (isInRangeRRR == true && Input.GetKey("e"))
        {
            SceneManager.UnloadSceneAsync("SpaceStation");
            SceneManager.LoadSceneAsync("RRRStart", LoadSceneMode.Single);
        }
    }
}
