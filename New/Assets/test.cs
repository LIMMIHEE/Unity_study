using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
      int A = 10;
      Debug.Log(A);
      int B = 20;
      Debug.Log(B);
      Debug.Log(A + B);

      string name = "togi";
      Debug.Log(name);
      */
public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(gameObject.name+transform.position);
        Debug.Log("result : "+ Calut(1, 5));
        Debug.Log("result : " +  Calut(10, 2));
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    int Calut(int A,int B)
    {
        Debug.Log("start");
        Debug.Log(A + B);
        Debug.Log(A - B);
        Debug.Log(A * B);
        Debug.Log(A / B);
        Debug.Log("End");

        return A + B;
    }
}
