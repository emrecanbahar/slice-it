using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fivtycmonus : MonoBehaviour
{
    public monettextmanager game;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Players"))
        {


            game.monney *= 50;
            game.money_text.text = game.monney.ToString();
            Debug.Log("winnerbonusx0");


        }

    }
}
