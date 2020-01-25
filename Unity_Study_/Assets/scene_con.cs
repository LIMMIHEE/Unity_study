using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_con : MonoBehaviour
{
   public void ScenLoad(string scenName)
    {
        SceneManager.LoadScene(scenName);
    }
    public void ScenLoad(int scennum)
    {
        SceneManager.LoadScene(scennum);
    }
}
