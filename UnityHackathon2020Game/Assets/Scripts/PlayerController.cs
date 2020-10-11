using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private int partCount = 0;

    private bool clickable = false;

    [Header("Character Attributes:")]
    public float baseMovementSpeed = 2.0f;
    public float baseRunningSpeedMultiplier = 2.0f;

    [Header("Level Attributes:")]
    public int totalResets = 1;

    [Space]
    [Header("Character Statistics:")]
    public Vector2 movementDirection;
    public float movementSpeed;
    public bool isRunning = false;

    [Space]
    [Header("References:")]
    public Rigidbody2D rb;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            clickable = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        clickable = false;
    }

    public bool IsClickable()
    {
        return clickable;
    }

    public void IncreasePartCount()
    {
        partCount += 1;
        Debug.Log(partCount);
    }

    public int GetScore()
    {
        return partCount;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        Move();
        Animate();
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

    void Animate()
    {
        if(movementDirection != Vector2.zero)
        {
            animator.SetFloat("Horizontal", movementDirection.x);
            animator.SetFloat("Vertical", movementDirection.y);
        }
        animator.SetFloat("Speed", movementSpeed);
        if (isRunning)
        {
            animator.SetFloat("Running", 1f);
        } else
        {
            animator.SetFloat("Running", 0f);
        }
    }

    public int GetTotalResets()
    {
        return totalResets;
    }
}
