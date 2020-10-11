using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    public Button playButton;
    public GameObject levelButtons;

    public void Back(){
        playButton.gameObject.SetActive(true);
        levelButtons.SetActive(false);
    }
    public void SelectLevel(){
        playButton.gameObject.SetActive(false);
        levelButtons.SetActive(true);
    }
    public void Play(int sceneIndex){
        SceneManager.LoadScene(sceneIndex);
    }
}
