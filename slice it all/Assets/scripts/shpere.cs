using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shpere : MonoBehaviour
{
    public monettextmanager game;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Saw")
        {
            Cut(other.gameObject.transform);
        }
    }
    public void Cut(Transform cutter)
    {
        if (cutter.transform.position.x < 0)
        {
            // scale 2 x:1 cutter x -0.5      
            // left
            float y = transform.localScale.y;
            y += transform.position.x;
            float dist = y - cutter.position.x;
            Debug.Log("dist : " + dist);
            if ( 3> 0)
            {
                // 3 -0.5=2.5
                // 0 + 0.5 = 0.5

                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - dist / 3, transform.localScale.z);
                transform.position = new Vector3(transform.position.x + dist / 3, transform.position.y, transform.position.z);
               
                GameObject yeni = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                //gameObject.SetActive(false);
                yeni.transform.localScale = new Vector3(transform.localScale.x, dist / 3, transform.localScale.z);
               yeni.transform.rotation = transform.rotation;
               yeni.transform.position = new Vector3(-(y - yeni.transform.localScale.y), transform.position.y, transform.position.z);

               yeni.AddComponent<Rigidbody>();
            }

        }
        game.monney++;
        game.money_text.text = game.monney.ToString();

    }

   



}



