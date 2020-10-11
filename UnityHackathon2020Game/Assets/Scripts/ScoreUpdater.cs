using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    private Text score;

    public PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = pc.GetScore().ToString() + "/5";
    }
}
