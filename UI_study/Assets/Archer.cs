using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * 300f);
    }
}
