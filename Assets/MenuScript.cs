using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuScript :MonoBehaviour
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
    public AudioMixer audioMixer;
    public void ForceFullscreen()
    {
        Screen.fullScreen = true;
        Debug.Log("in fullscreen mode");
    }
    public void ForceWindowed()
    {
        Screen.fullScreen = false;
        Debug.Log("in windowed mode");
    }
    public void SetMusicVolume(float BGMVol)
    {
        Debug.Log(BGMVol);
        audioMixer.SetFloat("BGMVolume",BGMVol);
    }
    public void SetFXVolume(float FXVol)
    {
        Debug.Log(FXVol);
        audioMixer.SetFloat("FXVolume",FXVol);
    }
}
