using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManuSceneController : MonoBehaviour
{

    public Text gameNameText;
    public Button playButton;
    public Button optionsButton;
    public Button exitButton;

    private void Start()
    {
        gameNameText.transform.position = new Vector3(0.5f * Screen.width, 0.9f * Screen.height, 0.0f);
        gameNameText.fontSize = Screen.height / 16;
        playButton.transform.position = new Vector3(0.5f * Screen.width, 0.7f * Screen.height, 0.0f);
        optionsButton.transform.position = new Vector3(0.5f * Screen.width, 0.45f * Screen.height, 0.0f);
        exitButton.transform.position = new Vector3(0.5f * Screen.width, 0.2f * Screen.height, 0.0f);
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
        SceneManager.LoadScene("OptionsScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
