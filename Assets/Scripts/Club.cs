using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Club : MonoBehaviour
{
    string[] namesArray = {"Putter", "Drive"};
    public string clubName = "";

    public Text nameText;

    void Start()
    {
        clubName = namesArray[0];
        nameText.text = clubName;
    }

    private void Update()
    {
        /*
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(Vector3.up, -10);
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(Vector3.up, 2);
        }
        */
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(clubName == namesArray[0])
            {
                clubName = namesArray[1];
                nameText.text = clubName;
            }
            else
            {
                clubName = namesArray[0];
                nameText.text = clubName;
            }
            
        }
    }
}
