using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangChange : MonoBehaviour
{
    public GameObject[] listObj;
    private GameObject[] listPL;
    private GameObject[] listEN;

    void Start()
    {
        for (int i = 0; i < listObj.Length; ++i)
        {
            listObj[i].SetActive(true);
        }

        listPL = GameObject.FindGameObjectsWithTag("PL");
        listEN = GameObject.FindGameObjectsWithTag("EN");

        

        foreach (GameObject PL in listPL)
        {
            PL.SetActive(false);
        }

        for (int i = 0; i < listObj.Length; ++i)
        {
            if (listObj[i].name != "MainMenu")
            {
                listObj[i].SetActive(false);
            }
        }
    }
    
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            for (int i = 0; i < listPL.Length; ++i)
            {
                listPL[i].SetActive(false);
                listEN[i].SetActive(true);
            }
        }
        if(val == 1)
        {
            for (int i = 0; i < listPL.Length; ++i)
            {
                listPL[i].SetActive(true);
                listEN[i].SetActive(false);
            }
        }
    }
}
