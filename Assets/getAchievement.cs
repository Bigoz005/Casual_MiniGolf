using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getAchievement : MonoBehaviour
{
    private Player player;
    public Image strike_1;
    public Image strike_100;
    public Image strike_1000;

    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    void Update()
    {
        player = GameObject.FindObjectOfType<Player>();
        if (player != null)
        {
            if (player.totalShots >= 1)
            {
                strike_1.color = new Color(255, 255, 255, 0.5f);
            }
            if (player.totalShots >= 100)
            {
                strike_100.color = new Color(255, 255, 255, 0.5f);
            }
            if (player.totalShots >= 1000)
            {
                strike_1000.color = new Color(255, 255, 255, 0.5f);
            }
        }
        
        
    }
}
