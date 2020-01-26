using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_m : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed);
    }
}
