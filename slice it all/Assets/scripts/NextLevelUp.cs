using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelUp : MonoBehaviour
{
    public GameObject nextlevelpnl;
    
    

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            nextlevelpnl.SetActive(true);
        }
        

    }
}
