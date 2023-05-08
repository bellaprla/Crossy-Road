using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void MenuButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        AudioManager.Instance.PlaySFX("klik");
    }
    public void ResetTheGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
