using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    private Animator _anim;
    public AudioClip clip;
    public AudioSource audiosource;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audiosource.PlayOneShot(clip);
            _anim.SetBool("opening", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        audiosource.PlayOneShot(clip);
        _anim.SetBool("opening", false);
    }



}
