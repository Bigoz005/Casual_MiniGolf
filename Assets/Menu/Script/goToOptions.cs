using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToOptions : MonoBehaviour
{
    public GameObject options;
    public GameObject menu;

    public void toOptions()
    {
        if (!options.activeSelf)
        {
            menu.SetActive(false);
            options.SetActive(true);
        }
        else
        {
            menu.SetActive(true);
            options.SetActive(false);
        }
    }
}
