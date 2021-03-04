using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadName : MonoBehaviour
{
    public Text NameBox;

    private void Start()
    {
        NameBox.text = PlayerPrefs.GetString("Character Name");
    }

    public void ResetSavedGame()
    {
        PlayerPrefs.DeleteKey("Character Name");
        SceneManager.LoadScene("SampleScene");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
