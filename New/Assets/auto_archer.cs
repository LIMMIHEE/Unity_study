using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_archer : MonoBehaviour
{
    public GameObject arrowObj;
    public Transform shootPos;
    private int frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        if (frame %100==0)
        {
            Instantiate(arrowObj).transform.position = shootPos.position;
        }
    }
}
