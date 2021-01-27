using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideAchievement : MonoBehaviour
{
    private Player player;

    public Animator achiev_1;
    public Animator achiev_100;
    public Animator achiev_1000;

    public void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    void Update()
    {
        player = GameObject.FindObjectOfType<Player>();
        if(player.totalShots == 1)
        {
            achiev_1.SetTrigger("isSlide");
        }
        if (player.totalShots == 100)
        {
            achiev_100.SetTrigger("isSlide");
        }
        if (player.totalShots == 1000)
        {
            achiev_1000.SetTrigger("isSlide");
        }
    }
}
