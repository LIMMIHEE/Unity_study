using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_2_test : MonoBehaviour
{
    public GameObject testObj;
    public Transform testTf;
    public KeyCode testKey;
    /*
    public int A=0;
    private int B=9;
    int C=20;
    */
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(testObj.name);
        Debug.Log(testTf.position);
        
        //Debug.Log(A);
        //Debug.Log(B);
        //Debug.Log(C);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
