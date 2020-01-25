using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //    Debug.Log(PlayerPrefs.GetInt("HighScore", 100));
        //PlayerPrefs.SetInt("HighScore", 1000);

        Debug.Log(PlayerPrefs.GetString("PlayerName", "N"));
        PlayerPrefs.SetString("PlayerName", "Marse");
    }
}