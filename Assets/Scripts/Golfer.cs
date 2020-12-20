using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Golfer : MonoBehaviour
{
    Club club;
    Hole hole;
    Ball ball;
    int strikes;
    int points;
    float power;
    public Text strikesText;
    public Text pointsText;

    void Start()
    {
        strikes = 0;
        points = 0;
        power = 0.0f;
        updateTextFields();
    }

    private void Update()
    {
        updateTextFields();

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime*2);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime*2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime*2);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime*2);
        }
    }

    private void updateTextFields()
    {
        pointsText.text = points.ToString();
        strikesText.text = strikes.ToString();
    }

}