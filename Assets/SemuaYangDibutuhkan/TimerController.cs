using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float totalTime = 900.0f; // 15 minutes in seconds
    private float currentTime = 0.0f;
    private bool timerRunning = true;

    public Text timerText; // Reference to the UI Text component

    void Update()
    {
        if (timerRunning)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= totalTime)
            {
                LoadOutroScene();
                timerRunning = false; // Stop the timer when it reaches the limit
            }

            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        float timeLeft = totalTime - currentTime;

        // Calculate minutes and seconds
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);

        // Update the UI Text with the formatted time
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void LoadOutroScene()
    {
        SceneManager.LoadScene("gameover");
    }
}
