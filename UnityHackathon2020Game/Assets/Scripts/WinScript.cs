using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    private Text txt;

    public TimeMachine tm;
    public PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pc.GetScore() >= 5 && tm.IsNear()){
            txt.enabled = true;
        }
        else
        {
            txt.enabled = false;
        }
    }
}
