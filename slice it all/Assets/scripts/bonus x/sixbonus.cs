using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sixbonus : MonoBehaviour
{
    public monettextmanager game;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {


            game.monney *= 6;
            game.money_text.text = game.monney.ToString();
            Debug.Log("winnerbonusx0");


        }

    }
}
