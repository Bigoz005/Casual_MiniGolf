using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startGame : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;

    public void LoadLevel(int indexScene)
    {
        StartCoroutine(LoadAsynchronously(indexScene));
    }

    IEnumerator LoadAsynchronously(int indexScene)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(indexScene);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            slider.value = progress;

            yield return null;
        }
    }
}
