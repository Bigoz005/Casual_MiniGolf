using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_off_music : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    public AudioSource [] musics;
    private Player player;

    public void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        refreshList();

        if (player.IsMusicOn)
        {
            on.SetActive(true);
            off.SetActive(false);

            foreach (AudioSource music in musics)
            {
                if (music.tag == "Music_Source")
                {
                    music.volume = 1.0f;
                }
            }

        }
        else
        {
            off.SetActive(true);
            on.SetActive(false);

            foreach (AudioSource music in musics)
            {
                if (music.tag == "Music_Source")
                {
                    music.volume = 0.0f;
                }
            }
        }
        
    }

    public void refreshList()
    {
        musics = GameObject.FindObjectsOfType<AudioSource>();
    }
    
    public void toggleOnOff()
    {
        refreshList();

        if (!on.activeSelf)
        {
            on.SetActive(true);
            off.SetActive(false);
            player.IsMusicOn = true;
            foreach (AudioSource music in musics)
            {
                if (music.tag == "Music_Source")
                {
                    music.volume = 1.0f;
                }
            }
        }
        else
        {
            off.SetActive(true);
            on.SetActive(false);
            player.IsMusicOn = false;
            foreach (AudioSource music in musics)
            {
                if (music.tag == "Music_Source")
                {
                    music.volume = 0.0f;
                }
            }
        }
    }
}
