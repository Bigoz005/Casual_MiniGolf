using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endPointsAndStrikes : MonoBehaviour
{
    private Player player;

    private int strikes;
    private int points;
    public Text strikesText;
    public Text pointsText;

    void Update()
    {
        player = GameObject.FindObjectOfType<Player>();
        strikes = player.totalShots;
        points = player.totalPoints;

        pointsText.text = points.ToString();
        strikesText.text = strikes.ToString();
    }
}
