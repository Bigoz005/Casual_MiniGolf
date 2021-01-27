using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCanvas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject gui;
    public GameObject controller;
    public bool click = false;

    void Start()
    {
        gui.SetActive(false);
        controller.SetActive(false);
        canvas.SetActive(true);
    }

    public void ButtonClicked()
    {
        canvas.SetActive(false);
        controller.SetActive(true);
        gui.SetActive(true);
        click = true;
    }

    public void Update()
    {
        if (click)
        {
            ActivateControlsAfterTime(3);
        }
    }

    IEnumerator ActivateControlsAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        controller.SetActive(true);
    }
}

