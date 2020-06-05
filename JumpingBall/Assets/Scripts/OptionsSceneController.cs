using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsSceneController : MonoBehaviour
{

    private float imageScreenWidthValue = 0.35f;
    private float textScreenWidthValue = 0.6f;
    private int fontSizeValue = Screen.height / 22;

    public Text controlDescriptionText;
    public Text gameDescriptionText;
    public Image slowSpeedDescriptionImage;
    public Image normalSpeedDescriptionImage;
    public Image fastSpeedDescriptionImage;
    public Image jumpDescriptionImage;
    public Text slowSpeedDescriptionText;
    public Text normalSpeedDescriptionText;
    public Text fastSpeedDescriptionText;
    public Text jumpDescriptionText;
    public Button backButton;

    private void Start()
    {
        controlDescriptionText.transform.position = new Vector3(0.5f * Screen.width, 0.95f * Screen.height, 0.0f);
        controlDescriptionText.fontSize = Screen.height / 16;

        slowSpeedDescriptionImage.transform.position = new Vector3(imageScreenWidthValue * Screen.width, 0.83f * Screen.height, 0.0f);
        slowSpeedDescriptionImage.rectTransform.sizeDelta = new Vector2(Screen.width / 12.0f, Screen.height / 12.0f);
        slowSpeedDescriptionImage.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 20;
        slowSpeedDescriptionText.transform.position = new Vector3(textScreenWidthValue * Screen.width, 0.83f * Screen.height, 0.0f);
        slowSpeedDescriptionText.fontSize = fontSizeValue;

        normalSpeedDescriptionImage.transform.position = new Vector3(imageScreenWidthValue * Screen.width, 0.73f * Screen.height, 0.0f);
        normalSpeedDescriptionImage.rectTransform.sizeDelta = new Vector2(Screen.width / 12.0f, Screen.height / 12.0f);
        normalSpeedDescriptionImage.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 20;
        normalSpeedDescriptionText.transform.position = new Vector3(textScreenWidthValue * Screen.width, 0.73f * Screen.height, 0.0f);
        normalSpeedDescriptionText.fontSize = fontSizeValue;

        fastSpeedDescriptionImage.transform.position = new Vector3(imageScreenWidthValue * Screen.width, 0.63f * Screen.height, 0.0f);
        fastSpeedDescriptionImage.rectTransform.sizeDelta = new Vector2(Screen.width / 12.0f, Screen.height / 12.0f);
        fastSpeedDescriptionImage.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 20;
        fastSpeedDescriptionText.transform.position = new Vector3(textScreenWidthValue * Screen.width, 0.63f * Screen.height, 0.0f);
        fastSpeedDescriptionText.fontSize = fontSizeValue;

        jumpDescriptionImage.transform.position = new Vector3(imageScreenWidthValue * Screen.width, 0.53f * Screen.height, 0.0f);
        jumpDescriptionImage.rectTransform.sizeDelta = new Vector2(Screen.width / 12.0f, Screen.height / 12.0f);
        jumpDescriptionImage.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 20;
        jumpDescriptionText.transform.position = new Vector3(textScreenWidthValue * Screen.width, 0.53f * Screen.height, 0.0f);
        jumpDescriptionText.fontSize = fontSizeValue;

        gameDescriptionText.transform.position = new Vector3(0.5f * Screen.width, 0.33f * Screen.height, 0.0f);
        gameDescriptionText.fontSize = fontSizeValue;

        backButton.transform.position = new Vector3(0.5f * Screen.width, 0.1f * Screen.height, 0.0f);
        backButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / 8.0f, Screen.height / 10.0f);
        backButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 18;
    }

    private void Update()
    {
        
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

}
