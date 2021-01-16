using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public AudioClip collisionHit;
    public AudioClip normalHit;
    public AudioClip hardHit;

    private int numOfCollisions;

    void Start()
    {
    }

    private void Update()
    {
    }

    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().clip = collisionHit;
        if (numOfCollisions >= 1) {
            GetComponent<AudioSource>().pitch = 2;
            GetComponent<AudioSource>().Play();
        }
        numOfCollisions++;
    }
}
