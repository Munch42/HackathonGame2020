using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedistolSpikes : MonoBehaviour
{
    private SpriteRenderer sr;
    private Sprite up;
    private bool switched = false;
    private BoxCollider2D bCollider;

    public Sprite down;

    //Get reference to switch that will open the door
    public Pedistol pedistol;


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
        //see if switch has been switched
        switched = pedistol.IsPressed();

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
