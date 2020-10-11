using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleCollectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundManagerScript.PlaySound("Objective");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Destroy(gameObject);
    }
}
