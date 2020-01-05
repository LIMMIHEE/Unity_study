using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    int frame = 0;
    /* frame ++;
        if (frame % 100 == 0)
        {
            Debug.Log("oh!");
        }
     */
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,4f);
        //transform.Translate(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.1f, 0f, 0f);
        //transform.Translate(Vector3.right);
        transform.Rotate(Vector3.forward);
        //transform.Rotate(Vector3.forward*5f);         //속도 빠르게 하기
    }
}
