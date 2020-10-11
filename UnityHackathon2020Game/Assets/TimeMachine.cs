using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMachine : MonoBehaviour
{
    private bool isNear = false;
    private BoxCollider2D bc;
    
    // Start is called before the first frame update
    void Start()
    {
        bc = gameObject.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isNear = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isNear = false;
    }

    public bool IsNear()
    {
        return isNear;
    }
}
