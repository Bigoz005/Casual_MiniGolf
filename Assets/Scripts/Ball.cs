using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public bool setCameraFocus = false;
    float weight = 0.5f;
    public float speed = 0.0f;
    float bounciness = 0.5f;
    float height = 0.0f;
    float metres = 0.0f;
    float currentLocationMetresX = 0.0f;
    float currentLocationMetresZ = 0.0f;
    float lastLocationMetresX = 0.0f;
    float lastLocationMetresZ = 0.0f;

    float x;
    float y;
    float z;
    public Text heightText;
    public Text metresText;
    public GameObject hole;

    void Start()
    {
        updateTextFields();
        lastLocationMetresX = this.transform.position.x;
        lastLocationMetresZ = this.transform.position.z;
        x = 0;
        y = 0;
        z = 0;
    }

    private void Update()
    {
        currentLocationMetresX = this.transform.position.x;
        currentLocationMetresZ = this.transform.position.z;

        if (currentLocationMetresX != lastLocationMetresX || currentLocationMetresZ != lastLocationMetresZ)
        {
            metres += 0.0125f;
            //dodac mnozenie przez predkosc
        }

        
        if (speed > 0) { 
            speed -= 2 * Time.deltaTime;
        }
        else
        {
            speed = 0;
            setCameraFocus = false;
        }
        /*
            z = speed * 0.005f;
            y = speed * 0.005f;
            x = speed * 0.005f;
        }
        this.transform.Translate(new Vector3(x, y, z) * Time.deltaTime * 0.25f);
        */

        height = this.transform.position.y;
        updateTextFields();

        lastLocationMetresX = currentLocationMetresX;
        lastLocationMetresZ = currentLocationMetresZ;
    }

    private void updateTextFields()
    {
        
        heightText.text = System.Math.Round(height, 2).ToString();
        metresText.text = System.Math.Round(metres, 0).ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Hole")
        {
            hole.GetComponent<Hole>().isIn = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Golf_Club") { 
            speed = 10;
            setCameraFocus = true;
        }
    }
}
