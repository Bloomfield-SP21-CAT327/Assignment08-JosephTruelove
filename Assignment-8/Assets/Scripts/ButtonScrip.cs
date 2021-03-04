using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScrip : MonoBehaviour
{
    public InputField textBox;

    public void ClickSaveButtone()
    {
        PlayerPrefs.SetString("Character Name", textBox.text);
        Debug.Log("The Character's name is " + PlayerPrefs.GetString("Character Name"));
        SceneManager.LoadScene("Game");
    }
}
