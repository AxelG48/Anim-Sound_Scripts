using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip audioClip2;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            audioSource.clip = audioClip;
            audioSource.Play();
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            audioSource.clip = audioClip2;
            audioSource.Play();
            anim.SetInteger("State", 2);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            audioSource.Stop();
            anim.SetInteger("State", 0);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            audioSource.Stop();
            anim.SetInteger("State", 0);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
