using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Character Attributes:")]
    public float baseMovementSpeed = 2.0f;
    public float baseRunningSpeedMultiplier = 2.0f;

    [Space]
    [Header("Character Statistics:")]
    public Vector2 movementDirection;
    public float movementSpeed;
    public bool isRunning = false;

    [Space]
    [Header("References:")]
    public Rigidbody2D rb;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        Move();
    }

    void ProcessInputs()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movementSpeed = Mathf.Clamp(movementDirection.magnitude, 0.0f, 1.0f);
        movementDirection.Normalize();

        if (Input.GetKey("left shift") || Input.GetKey("right shift"))
        {
            isRunning = true;
        } else
        {
            isRunning = false;
        }
    }

    void Move()
    {
        if (isRunning)
        {
            rb.velocity = movementDirection * movementSpeed * baseMovementSpeed * baseRunningSpeedMultiplier;
        } else
        {
            rb.velocity = movementDirection * movementSpeed * baseMovementSpeed;
        }
    }
}
