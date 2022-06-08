using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelGateOpening : MonoBehaviour
{
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("Open", true);
        }
    }
}
