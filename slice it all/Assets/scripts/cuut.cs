using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuut : MonoBehaviour
{
    public monettextmanager game;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            game.monney++;
            game.money_text.text = game.monney.ToString();
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            

        }
    }
}
