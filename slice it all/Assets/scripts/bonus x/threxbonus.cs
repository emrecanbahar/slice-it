using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class threxbonus : MonoBehaviour
{
    public monettextmanager game;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {


            game.monney *= 3;
            game.money_text.text = game.monney.ToString();
            Debug.Log("winnerbonusx0");


        }
    }
}
