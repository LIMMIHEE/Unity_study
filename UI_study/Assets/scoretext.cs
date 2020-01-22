using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class scoretext : MonoBehaviour
{
    int score = 0;
   
    public void ScoreUp(int num)
    {
        score += num;
        GetComponent<Text>().text = "Score :" + score;
    }
}
