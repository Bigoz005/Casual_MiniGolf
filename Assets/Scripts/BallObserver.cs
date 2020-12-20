using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallObserver : MonoBehaviour
{

    public GameObject ball;
    public GameObject player;

    void Update()
    {
        if (ball.GetComponent<Ball>().setCameraFocus) { 
            this.transform.position = new Vector3(ball.transform.position.x + 0.3f, ball.transform.position.y + 0.3f, ball.transform.position.z - 0.5f);
        }
        else
        {
            this.transform.position = new Vector3(player.transform.position.x + 1.0f, player.transform.position.y + 0.35f, player.transform.position.z - 1.0f);
        }
    } 
}
