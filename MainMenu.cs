using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start() {
        AudioManager.Instance.PlayMusic("Theme");
    }
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        AudioManager.Instance.PlaySFX("klik");
    }

    public void SettingGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        AudioManager.Instance.PlaySFX("klik");
    }

    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
        AudioManager.Instance.PlaySFX("klik");
    }
}
