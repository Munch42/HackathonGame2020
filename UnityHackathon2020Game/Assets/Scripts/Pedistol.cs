using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedistol : MonoBehaviour
{
    private bool isPressed = false;

    public GameObject barrel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.Equals(barrel.GetComponent<BoxCollider2D>()))
        {
            isPressed = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.Equals(barrel.GetComponent<BoxCollider2D>()))
        {
            isPressed = false;
        }
    }

    public bool IsPressed()
    {
        return isPressed;
    }
}
