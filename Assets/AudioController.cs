using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public bool mute = false;
    private AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (mute == false)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                mute = true;
                music.Stop();
            }
        }
        else if (mute == true)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                mute = false;
                music.Play();
            }
        }
        
    }
}
