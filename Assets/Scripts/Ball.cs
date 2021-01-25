using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public AudioClip collisionHit;
    public AudioClip normalHit;
    public AudioClip hardHit;
    public AudioSource source;

    private int numOfCollisions;

    public void Start()
    {
        source = GameObject.FindGameObjectWithTag("Ball_Sound_Source").GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        source.clip = collisionHit;
        if (numOfCollisions >= 1) {
            source.pitch = 2;
            source.Play();
        }
        numOfCollisions++;
    }
}
