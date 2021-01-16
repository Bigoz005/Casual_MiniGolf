using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public bool isIn = false;
    public int type = 3; // czy dolek jest na 3 uderzenia lub wiecej
    public AudioClip winSound;

    public Dictionary<string, int> PointsList = new Dictionary<string, int>();
    
    public void Start()
    {
        PointsList.Add("lol_XD_bogey", -5);
        PointsList.Add("triple_bogey", -3);
        PointsList.Add("double_bogey", -2);
        PointsList.Add("bogey", -1);
        PointsList.Add("par", -0);
        PointsList.Add("birdie", 1);
        PointsList.Add("eagle", 2);
        PointsList.Add("double_eagle", 3);
        PointsList.Add("condor", 4);
        PointsList.Add("ostrich", 5);
        PointsList.Add("hole_in_one", 10);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            isIn = true;
        }
    }
}
