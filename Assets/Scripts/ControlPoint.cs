using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{ 
    public Rigidbody ball;
    public Club club;
    public LineRenderer line;
    public Golfer golfer;

    private float xRot, yRot = 0f;
    public float rotationSpeed = 5f;
    public float shootPower = 30f;
    private float tempPower = 0f;


    void Update()
    {
        transform.position = ball.position;

        if (Input.GetMouseButton(0))
        {
            xRot += Input.GetAxis("Mouse X") * rotationSpeed;
            yRot += Input.GetAxis("Mouse Y") * rotationSpeed;

            if (club.clubName == "Drive")
            {
                if (yRot < -35f)
                {
                    yRot = -35f;
                }

                if (yRot > 10f)
                {
                    yRot = 10f;
                }

                tempPower = yRot;

                if (tempPower < 0)
                {
                    shootPower = -tempPower * 0.7f;
                }
                else
                {
                    shootPower = tempPower * 0.2f;
                }

                if (shootPower > -3 && shootPower < 3)
                {
                    shootPower = 3f;
                }
            }
            else
            {
                if (yRot < -20f)
                {
                    yRot = -20f;
                }

                if (yRot > 10f)
                {
                    yRot = 10f;
                }

                tempPower = yRot;

                if (tempPower < 0)
                {
                    shootPower = -tempPower * 0.8f;
                    if (shootPower > 8)
                    {
                        shootPower = 8;
                    }
                }
                else
                {
                    shootPower = tempPower * 0.3f;
                    if (shootPower > 8)
                    {
                        shootPower = 8;
                    }
                }

                if (shootPower > -2 && shootPower < 2)
                {
                    shootPower = 2f;
                }
            }
            transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
            line.gameObject.SetActive(true);
            line.SetPosition(0, transform.position + transform.forward * 0.15f);
            line.SetPosition(1, transform.position + transform.forward * 4f);

            if (shootPower < 8)
            {
                line.startColor = new Color(0, shootPower, 0);
            }
            else if (shootPower < 15)
            {
                line.startColor = new Color(shootPower, shootPower, 0);
            }
            else
            {
                line.startColor = new Color(shootPower, 0, 0);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(shootPower > 24)
            {
                ball.GetComponent<AudioSource>().clip = ball.GetComponentInParent<Ball>().hardHit;
                ball.GetComponent<AudioSource>().pitch = 4.5f;
                ball.GetComponent<AudioSource>().Play();
            }
            else
            {
                ball.GetComponent<AudioSource>().clip = ball.GetComponentInParent<Ball>().normalHit;
                ball.GetComponent<AudioSource>().pitch = 1;
                ball.GetComponent<AudioSource>().Play();
            }
            ball.velocity = transform.forward * shootPower;
            line.gameObject.SetActive(false);
            golfer.strikes++;
            golfer.player.GetComponent<Player>().totalShots++;
        }
    }
}
