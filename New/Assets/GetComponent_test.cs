using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent_test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<SpriteRenderer>().color = Color.blue;

        }
    }
}
