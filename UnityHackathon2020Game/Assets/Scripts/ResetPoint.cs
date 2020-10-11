using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPoint : MonoBehaviour
{
    [Header("Total Amount of Times they can reset to this point if global isn't specified.")]
    public int resetTotalAmount = 1;
    // This corresponds to the number key you must press to go to the specific reset point.
    [Header("The number key you must press to go to this point between 0-9")]
    public string resetNumber = "1";

    [Header("References:")]
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        resetTotalAmount = player.GetComponent<PlayerController>().GetTotalResets();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(resetNumber) && resetTotalAmount > 0)
        {
            SoundManagerScript.PlaySound("Reset");
            player.transform.position = this.transform.position;
            resetTotalAmount -= 1;
        }
        else if (Input.GetKeyDown(resetNumber))
            SoundManagerScript.PlaySound("Denied");
        {
            // Do something here when the player wants to reset but has used all their reset points.
        }
    }
}
