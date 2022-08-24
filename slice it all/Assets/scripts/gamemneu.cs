using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemneu : MonoBehaviour
{
    public void tekrar_oyna()
    {
        SceneManager.LoadScene("Scenes/game1");

        Time.timeScale = 1.0f;
    }
    public void NexttLevelButton()
    {
        Application.LoadLevel(1);
        // SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
