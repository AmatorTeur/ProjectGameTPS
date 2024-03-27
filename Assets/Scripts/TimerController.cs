using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerMinText;
    public TextMeshProUGUI timerSecText;
    public float totalTime = 120; // Время в секундах
    private float timeLeft;

    public GameObject gameplayUI;
    public GameObject gameOverScreen;

    private bool over = false;
    private void Start()
    {
        timeLeft = totalTime;
    }

    private void Update()
    {

        UpdateTimerDisplay();

        TimeRun();

        if (over)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
                SceneManager.LoadScene("Canvas", LoadSceneMode.Additive);
            }
        }

    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        timerMinText.text = string.Format("{0:00}", minutes);
        timerSecText.text = string.Format("{0:00}", seconds);
        over = false;
    }

    private void TimeRun()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;

            GameOver();
        }
    }

    private void GameOver()
    {
        gameplayUI.SetActive(false);
        gameOverScreen.SetActive(true);
        over = true;
    }

    private void Restart()
    {

    }
}
