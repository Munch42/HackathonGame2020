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

    public float overlapRadius = 1.5f;

    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        off = sr.sprite;
    }

    private void OnMouseOver()
    {
        LayerMask mask = LayerMask.GetMask("Player");
        //if (pc.IsClickable())
        //{
        //if object is clicked, change rotation and value of switched
        if (Input.GetMouseButtonDown(0) && Physics2D.OverlapCircle(this.transform.position, overlapRadius, mask))
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
        //}
    }

    //public reference to switched
    public bool isSwitched()
    {
        return switched;
    }
}
