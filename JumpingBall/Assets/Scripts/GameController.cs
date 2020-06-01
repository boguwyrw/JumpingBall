using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    private float widthDivider = 6.5f;
    private float heightDivider = 6.5f;

    public Button jumpButton;
    public Button slowSpeedButton;
    public Button normalSpeedButton;
    public Button fastSpeedButton;

    private void Start()
    {
        jumpButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        jumpButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 18;
        jumpButton.transform.position = new Vector3(0.85f * Screen.width, 0.15f * Screen.height, 0.0f);
        slowSpeedButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        slowSpeedButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 14;
        slowSpeedButton.transform.position = new Vector3(0.14f * Screen.width, 0.15f * Screen.height, 0.0f);
        normalSpeedButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        normalSpeedButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 14;
        normalSpeedButton.transform.position = new Vector3(0.3f * Screen.width, 0.15f * Screen.height, 0.0f);
        fastSpeedButton.image.rectTransform.sizeDelta = new Vector2(Screen.width / widthDivider, Screen.height / heightDivider);
        fastSpeedButton.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.height / 14;
        fastSpeedButton.transform.position = new Vector3(0.46f * Screen.width, 0.15f * Screen.height, 0.0f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
