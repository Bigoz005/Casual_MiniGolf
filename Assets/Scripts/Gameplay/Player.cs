using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int timesPlay = 0;
    public int totalShots = 0;
    public int clearedLevels = 0;
    public int totalPoints = 0;

    private bool isSoundOn = true;
    private bool isMusicOn = true;
    private bool isVibrationOn = true;

    public bool IsSoundOn { get => isSoundOn; set => isSoundOn = value; }
    public bool IsMusicOn { get => isMusicOn; set => isMusicOn = value; }
    public bool IsVibrationOn { get => isVibrationOn; set => isVibrationOn = value; }

    public static Player Instance;

    public void Awake()
    {
        this.InstantiateController();
    }

    private void InstantiateController()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != Instance)
        {
            Destroy(this.gameObject);
        }
    }

    public void Start()
    {
        this.InstantiateController();
    }
}
