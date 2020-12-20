using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Club : MonoBehaviour
{
    float power = 0.0f;
    float speed = 0.0f;
    string[] namesArray = {"Putter", "Drive"};
    string name = "";

    public Text nameText;

    void Start()
    {
        name = namesArray[0];
        nameText.text = name;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(Vector3.up, -2);            
        }

        if (Input.GetKey(KeyCode.E))
        {        
            this.transform.Rotate(Vector3.up, 2);   
        }
    }
}
