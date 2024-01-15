using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   
    public void NewGame(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }


    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
