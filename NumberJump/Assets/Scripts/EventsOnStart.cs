using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventsOnStart : MonoBehaviour
{
    public static bool IsStarted = false;
    public GameObject textNumberField;
    public GameObject cameraFollow;
    public GameObject buttonMenuUI;

    TextMeshProUGUI textNumberField_text;

    // Start is called before the first frame update
    void Start()
    {
        int random = Random.Range(10000, 99999);
        PlayerPrefs.SetInt("code", random);
        textNumberField_text = textNumberField.GetComponent<TextMeshProUGUI>();
        textNumberField_text.text = random.ToString();
        cameraFollow.SetActive(false);
        Cursor.lockState = CursorLockMode.None;

    }

    public void Resume()
    {
        Debug.Log("Resume");
        Cursor.lockState = CursorLockMode.Locked;
        cameraFollow.SetActive(true);
        buttonMenuUI.SetActive(false);
        IsStarted = true;
    }
}
