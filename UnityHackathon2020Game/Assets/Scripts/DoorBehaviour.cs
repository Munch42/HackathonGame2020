using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    private SpriteRenderer sr;
    private Sprite up;
    [SerializeField] private bool switched = false;
    private BoxCollider2D bCollider;

    public Sprite down;

    public bool ignoreSwitchOff = false;

    //Get reference to switch that will open the door
    public List<Switch> doorSwitch;
    

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        up = sr.sprite;
        bCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isSwitched = false;
        foreach(Switch item in doorSwitch){
            if(item.isSwitched() && !isSwitched){
                isSwitched = true;
            } else if(item.isSwitched()) {
                isSwitched = false;
            }
        }

        //see if switch has been switched
        if(!ignoreSwitchOff){
            switched = isSwitched;
        } else if(ignoreSwitchOff && isSwitched){
            switched = false;
        } else if(ignoreSwitchOff && !isSwitched){
            switched = true;    
        }

        //if door is open, hide from veiw
        //else keep door closed
        if (switched)
        {
            sr.sprite = down;
            bCollider.enabled = false;
        }
        else
        {
            sr.sprite = up;
            bCollider.enabled = true;
        }
    }
}
