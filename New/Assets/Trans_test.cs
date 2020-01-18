using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trans_test : MonoBehaviour
{
    int A = 100;
    string B = "1234";
    float C = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(A.ToString());
        Debug.Log(int.Parse(B));
        Debug.Log((int)C);

        Debug.Log(int.Parse("100") + 50);
        Debug.Log(123456.ToString("N0"));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
