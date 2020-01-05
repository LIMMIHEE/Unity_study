using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyListen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) // 키 누른 순간
        {
            //transform.Rotate(Vector3.forward * 30f);
            transform.Translate(Vector3.left * 0.1f);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) // 키에서 손 땔때
        {
            //transform.Rotate(Vector3.forward * 30f);
            transform.Translate(Vector3.right * 0.1f);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up *0.1f);
        }
    }
}
