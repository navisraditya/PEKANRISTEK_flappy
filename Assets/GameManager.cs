using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject startCanvas;
    public GameObject scoringCanvas;
    [SerializeField] private AudioSource startEffect;
    public bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        startCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);  
        scoringCanvas.SetActive(false);
    }

    public void StartGame()
    {
        check = true;
        startEffect.Play();
        Time.timeScale = 1;
        startCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        scoringCanvas.SetActive(true);
    }

    // Update is called once per frame
    public void GameOver()
    {
        check = false;
        Time.timeScale = 0;
        startCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
        scoringCanvas.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);  
    }

}
