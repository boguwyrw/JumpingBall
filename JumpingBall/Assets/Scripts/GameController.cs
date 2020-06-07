using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    private float widthDivider = 6.5f;
    private float heightDivider = 6.5f;
    private int playerHealthPoints;
    private int playerLives;
    private bool gameOver;
    private Player player;
    private bool playerFinishGame;
    private Finish finish;

    public Text livesText;
    public Slider healthSlider;
    public Image healthFill;
    public Image healthBackground;
    public Image healthHandle;

    public Button startButton;
    public Button jumpButton;
    public Button slowSpeedButton;
    public Button normalSpeedButton;
    public Button fastSpeedButton;
    public Button X_Button;
    public Button resumeButton;
    public Button quitButton;

    public Text gameOverText;

    private void Start()
    {
        Time.timeScale = 0;
        playerHealthPoints = 0;
        playerLives = 0;
        gameOver = false;
        player = FindObjectOfType<Player>();
        playerFinishGame = false;
        finish = FindObjectOfType<Finish>();

        livesText.transform.position = new Vector3(0.06f * Screen.width, 0.95f * Screen.height, 0.0f);
        livesText.fontSize = Screen.height / 25;

        healthSlider.transform.position = new Vector3(0.075f * Screen.width, 0.85f * Screen.height, 0.0f);
        healthSlider.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 25;
        healthFill.color = new Color(255, 255, 0);
        healthBackground.color = new Color(255, 0, 0);
        healthHandle.color = new Color(255, 255, 0);

        startButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        startButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 18;
        startButton.transform.position = new Vector3(0.5f * Screen.width, 0.5f * Screen.height, 0.0f);

        jumpButton.gameObject.SetActive(false);
        jumpButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        jumpButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 18;
        jumpButton.transform.position = new Vector3(0.85f * Screen.width, 0.15f * Screen.height, 0.0f);

        slowSpeedButton.gameObject.SetActive(false);
        slowSpeedButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        slowSpeedButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 14;
        slowSpeedButton.transform.position = new Vector3(0.14f * Screen.width, 0.15f * Screen.height, 0.0f);

        normalSpeedButton.gameObject.SetActive(false);
        normalSpeedButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        normalSpeedButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 14;
        normalSpeedButton.transform.position = new Vector3(0.3f * Screen.width, 0.15f * Screen.height, 0.0f);

        fastSpeedButton.gameObject.SetActive(false);
        fastSpeedButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        fastSpeedButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 14;
        fastSpeedButton.transform.position = new Vector3(0.46f * Screen.width, 0.15f * Screen.height, 0.0f);

        X_Button.gameObject.SetActive(false);
        X_Button.image.rectTransform.sizeDelta = new Vector2(35, 35);
        X_Button.transform.GetChild(0).GetComponent<Text>().fontSize = 28;
        X_Button.transform.position = new Vector3(0.95f * Screen.width, 0.95f * Screen.height, 0.0f);

        resumeButton.gameObject.SetActive(false);
        resumeButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        resumeButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 18;
        resumeButton.transform.position = new Vector3(0.5f * Screen.width, 0.6f * Screen.height, 0.0f);

        quitButton.gameObject.SetActive(false);
        quitButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        quitButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 18;
        quitButton.transform.position = new Vector3(0.5f * Screen.width, 0.4f * Screen.height, 0.0f);

        gameOverText.gameObject.SetActive(false);
        gameOverText.fontSize = Screen.height / 18;
    }

    private void Update()
    {
        playerHealthPoints = player.GetHealthPoints();
        playerLives = player.GetNumberOfLives();
        gameOver = player.GetGameOver();
        healthSlider.value = playerHealthPoints;
        livesText.text = "Lives: " + playerLives.ToString();
        if (gameOver)
        {
            gameOverText.gameObject.SetActive(true);
            //Time.timeScale = 0;
        }

        playerFinishGame = finish.GetPlayerFinished();
        if (playerFinishGame)
        {
            slowSpeedButton.gameObject.SetActive(false);
            normalSpeedButton.gameObject.SetActive(false);
            fastSpeedButton.gameObject.SetActive(false);
            jumpButton.gameObject.SetActive(false);
            resumeButton.interactable = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void StartGameButton()
    {
        startButton.gameObject.SetActive(false);
        jumpButton.gameObject.SetActive(true);
        slowSpeedButton.gameObject.SetActive(true);
        normalSpeedButton.gameObject.SetActive(true);
        fastSpeedButton.gameObject.SetActive(true);
        X_Button.gameObject.SetActive(true);
        Time.timeScale = 1;
    }

    public void X_GameButton()
    {
        Time.timeScale = 0;
        if (gameOver)
        {
            resumeButton.interactable = false;
        }
        else
        {
            resumeButton.interactable = true;
        }
        resumeButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        jumpButton.interactable = false;
        slowSpeedButton.interactable = false;
        normalSpeedButton.interactable = false;
        fastSpeedButton.interactable = false;
    }

    public void ResumeGameButton()
    {
        Time.timeScale = 1;
        resumeButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
        jumpButton.interactable = true;
        slowSpeedButton.interactable = true;
        normalSpeedButton.interactable = true;
        fastSpeedButton.interactable = true;
    }

    public void QuitGameButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

}
