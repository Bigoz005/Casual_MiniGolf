using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSlide : MonoBehaviour
{
    private Player player;
    public Animator animator_1;
    public Animator animator_100;
    public Animator animator_1000;

    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    public void Update()
    {
        player = GameObject.FindObjectOfType<Player>();
        if (player.totalShots == 1)
        {
            if(animator_1 != null)
                animator_1.SetTrigger("isSlide");
        }
        if (player.totalShots == 100)
        {
            animator_100.SetTrigger("isSlide");
        }

        if (player.totalShots == 1000)
        {
            animator_1000.SetTrigger("isSlide");
        }

    }
}
