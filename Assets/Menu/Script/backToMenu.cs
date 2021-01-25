using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToMenu : MonoBehaviour
{

    public GameObject menu;
    public GameObject options;

    public void toMenu()
    {
        if (!menu.activeSelf)
        {
            menu.SetActive(true);
            options.SetActive(false);
        }
        else
        {
            menu.SetActive(false);
            options.SetActive(true);
        }
    }
}