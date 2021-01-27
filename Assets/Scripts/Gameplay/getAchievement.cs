using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getAchievement : MonoBehaviour
{
    private Player player;

    public Image achiev_1;
    public Image achiev_100;
    public Image achiev_1000;
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindObjectOfType<Player>();
        if (player.totalShots >= 1)
        {
            achiev_1.color = new Color(255, 255, 255, 0.5f);
        }
        if (player.totalShots >= 100)
        {
            achiev_100.color = new Color(255, 255, 255, 0.5f);
        }
        if (player.totalShots >= 1000)
        {
            achiev_1000.color = new Color(255, 255, 255, 0.5f);
        }
    }
}
