using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int timesPlay = 0;
    public int totalShots = 0;
    public int clearedLevels = 0;
    public int totalPoints = 0;

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
