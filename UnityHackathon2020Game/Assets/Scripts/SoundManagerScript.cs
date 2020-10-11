using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip SwitchSound, ResetSound, ObjectiveSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        SwitchSound = Resources.Load<AudioClip>("Switch&Spike");
        ResetSound = Resources.Load<AudioClip>("Reset");
        ObjectiveSound = Resources.Load<AudioClip>("Objective");

        audioSrc = GetComponent<AudioSource>();
    }   

    // Update is called once per frame
    void Update()
    {

    }
        public static void PlaySound(string clip)
        {
            switch (clip)
                {
                case "Switch&Spike":
                    audioSrc.PlayOneShot(SwitchSound);
                    break;
                case "Reset":
                    audioSrc.PlayOneShot(ResetSound);
                    break;
                case "Objective":
                    audioSrc.PlayOneShot(ObjectiveSound);
                    break;
            }
        }
}
