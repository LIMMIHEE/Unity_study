using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public GameObject testobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * 300f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            testobj.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            testobj.SetActive(true);
        }
    }
}
