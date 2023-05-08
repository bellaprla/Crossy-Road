using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{
    public void MenuButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        AudioManager.Instance.PlaySFX("klik");
    }
}
