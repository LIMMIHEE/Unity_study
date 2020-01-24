using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    public void ShootBtn()
    {
        
        GetComponent<Animator>().SetTrigger("shoot_t");
        //GetComponent<Animator>().SetBool("TestBool",true);
        float tempHp = GetComponent<Animator>().GetFloat("HP");
        if (tempHp<10)
        {
            GetComponent<Animator>().SetTrigger("Die_t");
        }
        GetComponent<Animator>().SetFloat("HP", tempHp-10);
    }
}
