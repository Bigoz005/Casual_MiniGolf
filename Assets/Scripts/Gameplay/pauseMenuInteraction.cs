using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuInteraction : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject ballController;

    public void Start()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Update()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
        {
            if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.activeSelf == false)
            {
                ballController.SetActive(false);
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        else if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.activeSelf == false)
            {
                ballController.SetActive(false);
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void continueGame()
    {
        ballController.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
