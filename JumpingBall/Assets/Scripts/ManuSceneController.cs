using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManuSceneController : MonoBehaviour
{

    public Button playButton;
    public Button optionsButton;
    public Button exitButton;

    private void Start()
    {

    }

    private void Update()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OptionsGame()
    { 
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
