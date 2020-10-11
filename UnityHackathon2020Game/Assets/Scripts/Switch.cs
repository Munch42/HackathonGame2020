using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private bool switched = false;
    private SpriteRenderer sr;
    private Sprite off;

    public PlayerController pc;
    public Sprite on;

    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        off = sr.sprite;
    }

    private void OnMouseOver()
    {
        if (pc.IsClickable())
        {
            //if object is clicked, change rotation and value of switched
            if (Input.GetMouseButtonDown(0))
            {
                if (switched)
                {
                    switched = false;
                    sr.sprite = off;
                }
                else
                {
                    switched = true;
                    sr.sprite = on;

                }
            }
        }
    }

    //public reference to switched
    public bool isSwitched()
    {
        return switched;
    }
}
