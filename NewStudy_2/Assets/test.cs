using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject arrobj;
    public KeyCode shootKey;
    public Transform shootPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            Instantiate(arrobj).transform.position = shootPos.position;
        }
    }
}
