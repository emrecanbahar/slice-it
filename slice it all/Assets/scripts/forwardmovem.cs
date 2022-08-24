using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;




public class forwardmovem : MonoBehaviour
{
    public float jump;
    public Rigidbody rb;
    
    private void Start()
    {
        transform.Rotate(0, -90, 0);
        return;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Start();

            rb.velocity = Vector3.up * jump;
        }
    }
}
