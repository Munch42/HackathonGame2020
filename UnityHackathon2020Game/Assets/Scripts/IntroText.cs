using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class IntroText : MonoBehaviour
{
    float time = 7.0f;
    private Text txt;

    private void Start()
    {
        txt = GetComponent<Text>();
    }

    void Update()
    {

        if (time >= 0)
        {
            time -= Time.deltaTime;
            return;
        }
        else
        {
            txt.enabled = false;
        }
    }
}
