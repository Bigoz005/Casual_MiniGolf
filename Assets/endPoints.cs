using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endPoints : MonoBehaviour
{

    private Player player;
    private int strikes;
    private int points;
    public Text strikeText;
    public Text pointsText;

    void Update()
    {
        player = GameObject.FindObjectOfType<Player>();
        strikes = player.totalShots;
        points = player.totalPoints;
        strikeText.text = strikes.ToString();
        pointsText.text = points.ToString();
    }
}
