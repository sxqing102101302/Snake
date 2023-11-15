using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public GameObject gameOverUI;
    //public GameObject gameOverUI1;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        //Application.Quit(); 
        SceneManager.LoadScene(0);
    }
    public static void GameOver(bool dead)
    {
        if (dead)
        {
            instance.gameOverUI.SetActive(true);
            //instance.gameOverUI1.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
