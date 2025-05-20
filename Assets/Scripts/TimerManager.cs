using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    [Header("UI")]
    public Text timerText;

    private float elapsedTime = 0f;
    private bool running = true;

    // Allows other scripts to read the time
    public float ElapsedTime => elapsedTime;

    void Update()
    {
        if (!running) return;

        elapsedTime += Time.deltaTime;
        UpdateTimerUI();
    }

    void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    /// <summary>
    /// Call this to stop counting time.
    /// </summary>
    public void StopTimer()
    {
        running = false;
    }
}
