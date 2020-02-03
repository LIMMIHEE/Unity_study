using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_m : MonoBehaviour
{
    public float JumpPower = 300f;
    public float moveSpeed = 0.05f;

    public GameManager gameManager;
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed);
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * JumpPower);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.name == "WinCollider")
        {
            gameManager.Win();
        }
        else if (col.transform.name == "loseCollider")
        {
            Debug.Log("Lose!");
        }
    }
}
