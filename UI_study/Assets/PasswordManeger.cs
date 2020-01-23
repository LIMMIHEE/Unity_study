using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordManeger : MonoBehaviour
{
    public InputField inputField;

    public void Okbtn()
    {
        if (inputField.text.Equals("12345"))
        {
            Debug.Log("pass");
        }
        else
        {
            Debug.Log("false");
        }

    }
}
