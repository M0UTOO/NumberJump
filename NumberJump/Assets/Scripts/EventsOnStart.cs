using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventsOnStart : MonoBehaviour
{
    public static bool IsStarted = false;
    public static int random;
    public GameObject textNumberField;
    public GameObject cameraFollow;
    public GameObject buttonMenuUI;
    TextMeshProUGUI textNumberField_text;

    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(10000, 99999);
        textNumberField_text = textNumberField.GetComponent<TextMeshProUGUI>();
        textNumberField_text.text = random.ToString();
        cameraFollow.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cameraFollow.SetActive(true);
        buttonMenuUI.SetActive(false);
        IsStarted = true;
        Time.timeScale = 1f;
    }
}
