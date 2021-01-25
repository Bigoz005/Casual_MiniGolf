using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToAchievement : MonoBehaviour
{
    public GameObject achievement;
    public GameObject menu;

    public void toAchievement()
    {
        if (!achievement.activeSelf)
        {
            menu.SetActive(false);
            achievement.SetActive(true);
        }
        else
        {
            menu.SetActive(true);
            achievement.SetActive(false);
        }
    }
}
