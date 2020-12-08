using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    float weight = 0.5f;
    public float speed = 0.0f;
    float bounciness = 0.5f;
    float height = 0.0f;
    float metres = 0.0f;

    float x;
    float y;
    float z;
    public Text heightText;
    public Text metresText;
    public GameObject hole;

    void Start()
    {
        updateTextFields();
        x = 0;
        y = 0;
        z = 0;
    }

    private void Update()
    {
        updateTextFields();
        if(speed > 0) { 
            speed -= 1 * Time.deltaTime;
            z = -speed;
            y = speed;
            x = speed * 0.005f;
        }
        this.transform.Translate(new Vector3(x, y, z) * Time.deltaTime * 0.5f);
        height = this.transform.position.y;
    }

    private void updateTextFields()
    {
        heightText.text = height.ToString();
        metresText.text = metres.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Capsule")
        {
            speed = 5.0f;
        }

        if (other.gameObject.name == "Hole")
        {
            hole.GetComponent<Hole>().isIn = true;
        }
    }
}
