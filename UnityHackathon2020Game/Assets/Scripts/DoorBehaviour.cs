using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    private SpriteRenderer sr;
    private bool switched = false;

    //Get reference to switch that will open the door
    public Switch doorSwitch;
    

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //see if switch has been switched
        switched = doorSwitch.isSwitched();

        //if door is open, hide from veiw
        //else keep door closed
        if (switched)
        {
            sr.enabled = false;
        }
        else
        {
            sr.enabled = true;
        }
    }
}
