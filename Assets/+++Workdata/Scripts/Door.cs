using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Collider playerCollider;
    public Animator animator;
    public AudioSource doorOpenSound;
    public AudioSource doorCloseSound;
    public AudioSource doorCreekSound;
    public float openTime = 1f;
    public float closeTime = 1f;
    private IEnumerator coroutine;


    void OnTriggerEnter(Collider other)
    {
        animator.SetBool("isOpen", true);
        doorOpenSound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isOpen", false);
        doorCreekSound.Play();
        doorCloseSound.Play();
    }
    private IEnumerator DoorOpen(float openTime)
    {
        while(true)
        {
            yield return new WaitForSeconds(openTime);
        }
    }
}