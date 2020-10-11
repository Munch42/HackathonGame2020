using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TimeMachinePart : MonoBehaviour
{

    public PlayerController pc;
    public float speed = 35.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundManagerScript.PlaySound("Objective");
        pc.IncreasePartCount();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
    
}
