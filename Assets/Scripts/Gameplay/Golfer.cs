using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Golfer : MonoBehaviour
{
    Club club;
    Ball ball;
    public Player player;
    public Hole hole;
    public GameObject ballController;
    public GameObject mainCanvas;

    public int strikes;
    int points;
    public Text strikesText;
    public Text pointsText;
    public bool finished = false;
    public bool addShowed = false;
    public GameObject level_complete;
    public GameObject GUI;

    public AudioSource[] audioSources;
    private AdsManager adsManager;

    void Start()
    {
        this.gameObject.AddComponent<AdsManager>();
        adsManager = this.gameObject.GetComponent<AdsManager>();
        player = GameObject.FindObjectOfType<Player>();
        strikes = player.totalShots;
        points = player.totalPoints;
        updateTextFields();
        audioSources = GameObject.FindObjectsOfType<AudioSource>();
        player.timesPlay++;
        checkAudioSettings();
    }

    private void checkAudioSettings()
    {
        foreach (AudioSource sound in audioSources)
        {
            if (sound.tag == "Sound_Source")
            {
                if (player.IsSoundOn)
                {
                    sound.volume = 1.0f;
                }
                else
                {
                    sound.volume = 0.0f;
                }
            }

            if (sound.tag == "Ball_Sound_Source")
            {
                if (player.IsSoundOn)
                {
                    sound.volume = 1.0f;
                }
                else
                {
                    sound.volume = 0.0f;
                }
            }

            if (sound.tag == "Music_Source")
            {
                if (player.IsMusicOn)
                {
                    sound.volume = 1.0f;
                }
                else
                {
                    sound.volume = 0.0f;
                }
            }
        }
    }

    private void Update()
    {
        updateTextFields();

        if (hole.isIn)
        {
            ballController.SetActive(false);
            mainCanvas.SetActive(false);
            //wyswietl wynik dolka i przenies do sceny wyboru poziomu
            if (!finished)
            {
                player.totalPoints += points;
                player.clearedLevels++;
                hole.GetComponent<AudioSource>().clip = hole.winSound;
                hole.GetComponent<AudioSource>().loop = false;
                hole.GetComponent<AudioSource>().Play();
                finished = true;
            }
            Time.timeScale = 0;
            if (!addShowed) { 
                adsManager.ShowIntestitialAd();
                addShowed = true;
            }

            if (adsManager.interstitialClosed)
            {
                level_complete.SetActive(true);
                GUI.SetActive(false);
            }
        }
        else
        {
            //punktacja w zaleznosci od typu dolka
            ballController.SetActive(true);
            mainCanvas.SetActive(true);
            switch (hole.type)
            {
                case 3:
                    switch (strikes)
                    {
                        case 0:
                            break;
                        case 1:
                            points = hole.PointsList["hole_in_one"];
                            break;
                        case 2:
                            points = hole.PointsList["birdie"];
                            break;
                        case 3:
                            points = hole.PointsList["par"];
                            break;
                        case 4:
                            points = hole.PointsList["bogey"];
                            break;
                        case 5:
                            points = hole.PointsList["double_bogey"];
                            break;
                        case 6:
                            points = hole.PointsList["triple_bogey"];
                            break;
                        default:
                            points = hole.PointsList["lol_XD_bogey"];
                            break;
                    }
                    break;
                case 4:
                    switch (strikes)
                    {
                        case 0:
                            break;
                        case 1:
                            points = hole.PointsList["hole_in_one"];
                            break;
                        case 2:
                            points = hole.PointsList["eagle"];
                            break;
                        case 3:
                            points = hole.PointsList["birdie"];
                            break;
                        case 4:
                            points = hole.PointsList["par"];
                            break;
                        case 5:
                            points = hole.PointsList["bogey"];
                            break;
                        case 6:
                            points = hole.PointsList["double_bogey"];
                            break;
                        case 7:
                            points = hole.PointsList["triple_bogey"];
                            break;
                        default:
                            points = hole.PointsList["lol_XD_bogey"];
                            break;
                    }
                    break;
                case 5:
                    switch (strikes)
                    {
                        case 0:
                            break;
                        case 1:
                            points = hole.PointsList["hole_in_one"];
                            break;
                        case 2:
                            points = hole.PointsList["double_eagle"];
                            break;
                        case 3:
                            points = hole.PointsList["eagle"];
                            break;
                        case 4:
                            points = hole.PointsList["birdie"];
                            break;
                        case 5:
                            points = hole.PointsList["par"];
                            break;
                        case 6:
                            points = hole.PointsList["bogey"];
                            break;
                        case 7:
                            points = hole.PointsList["double_bogey"];
                            break;
                        case 8:
                            points = hole.PointsList["triple_bogey"];
                            break;
                        default:
                            points = hole.PointsList["lol_XD_bogey"];
                            break;
                    }
                    break;
                case 6:
                    switch (strikes)
                    {
                        case 0:
                            break;
                        case 1:
                            points = hole.PointsList["hole_in_one"];
                            break;
                        case 2:
                            points = hole.PointsList["condor"];
                            break;
                        case 3:
                            points = hole.PointsList["double_eagle"];
                            break;
                        case 4:
                            points = hole.PointsList["eagle"];
                            break;
                        case 5:
                            points = hole.PointsList["birdie"];
                            break;
                        case 6:
                            points = hole.PointsList["par"];
                            break;
                        case 7:
                            points = hole.PointsList["bogey"];
                            break;
                        case 8:
                            points = hole.PointsList["double_bogey"];
                            break;
                        case 9:
                            points = hole.PointsList["triple_bogey"];
                            break;
                        default:
                            points = hole.PointsList["lol_XD_bogey"];
                            break;
                    }
                    break;
                case 7:
                    switch (strikes)
                    {
                        case 0:
                            break;
                        case 1:
                            points = hole.PointsList["hole_in_one"];
                            break;
                        case 2:
                            points = hole.PointsList["ostrich"];
                            break;
                        case 3:
                            points = hole.PointsList["condor"];
                            break;
                        case 4:
                            points = hole.PointsList["double_eagle"];
                            break;
                        case 5:
                            points = hole.PointsList["eagle"];
                            break;
                        case 6:
                            points = hole.PointsList["birdie"];
                            break;
                        case 7:
                            points = hole.PointsList["par"];
                            break;
                        case 8:
                            points = hole.PointsList["bogey"];
                            break;
                        case 9:
                            points = hole.PointsList["double_bogey"];
                            break;
                        case 10:
                            points = hole.PointsList["triple_bogey"];
                            break;
                        default:
                            points = hole.PointsList["lol_XD_bogey"];
                            break;
                    }
                    break;
                default:
                    switch (strikes)
                    {
                        case 0:
                            break;
                        case 1:
                            points = hole.PointsList["hole_in_one"];
                            break;
                        case 2:
                            points = hole.PointsList["birdie"];
                            break;
                        case 3:
                            points = hole.PointsList["par"];
                            break;
                        case 4:
                            points = hole.PointsList["bogey"];
                            break;
                        case 5:
                            points = hole.PointsList["double_bogey"];
                            break;
                        case 6:
                            points = hole.PointsList["triple_bogey"];
                            break;
                        default:
                            points = hole.PointsList["lol_XD_bogey"];
                            break;
                    }
                    break;
            }
            /*
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * 2);
            }

            if (Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * 2);
            }

            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate(Vector3.left * Time.deltaTime * 2);
            }

            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate(Vector3.right * Time.deltaTime * 2);
            }
            */
        }
    }

    private void updateTextFields()
    {
        pointsText.text = points.ToString();
        strikesText.text = strikes.ToString();
    }

    IEnumerator ChangeSceneAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Levels");
    }
}