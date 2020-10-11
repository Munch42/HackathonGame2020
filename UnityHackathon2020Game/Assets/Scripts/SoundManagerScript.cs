using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip SwitchSound, ResetSound, ObjectiveSound, DeniedSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        SwitchSound = Resources.Load<AudioClip>("Switch");
        ResetSound = Resources.Load<AudioClip>("Reset");
        ObjectiveSound = Resources.Load<AudioClip>("Objective");
        DeniedSound = Resources.Load<AudioClip>("Denied");

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
                case "Switch":
                    audioSrc.PlayOneShot(SwitchSound);
                    break;
                case "Reset":
                    audioSrc.PlayOneShot(ResetSound);
                    break;
                case "Objective":
                    audioSrc.PlayOneShot(ObjectiveSound);
                    break;
            case "Denied":
                audioSrc.PlayOneShot(DeniedSound);
                break;
            }
        }
}
