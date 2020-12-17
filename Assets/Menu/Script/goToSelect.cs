using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToSelect : MonoBehaviour
{
    public GameObject select;
    public GameObject menu;

    public void toSelect()
    {
        if (!select.activeSelf)
        {
            menu.SetActive(false);
            select.SetActive(true);
        }
        else
        {
            menu.SetActive(true);
            select.SetActive(false);
        }
    }
}
