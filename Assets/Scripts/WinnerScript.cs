using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class WinnerScript : MonoBehaviour
{
    public GameObject winnerBackground;
    public GameObject winnerLogo;
    public Text timeVictoryText;
    public Text timeGameText;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public Text Texts;
    public List<GameObject> carObjects = new List<GameObject>();
    public List<GameObject> targetPos = new List<GameObject>();
    public GameObject Back;
    public GameObject Retry;

    private float startTime;
    private bool timerRunning = false;
    private float endTime;

    public void Start()
    {
        winnerBackground.SetActive(false);
        winnerLogo.SetActive(false);
        timeVictoryText.gameObject.SetActive(false);
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
        Texts.gameObject.SetActive(false);
        Back.gameObject.SetActive(false);
        Retry.gameObject.SetActive(false);

        startTime = Time.time;
        timerRunning = true;
    }

    public void Update()
    {
        if (timerRunning)
        {
            endTime = Time.time - startTime;
            timeVictoryText.text = FormatTime(endTime);
            timeGameText.text = FormatTime(endTime);
            if (CheckVeh())
            {
                timerRunning = false;
                ShowWinScreen();
            }
        }
    }

    public bool CheckVeh()
    {
        for (int i = 0; i < carObjects.Count; i++)
        {
            if (carObjects[i] == null || targetPos[i] == null)
                return false;

            if (Vector3.Distance(carObjects[i].transform.position, targetPos[i].transform.position) > 1f)
                return false;
        }
        return true;
    }

    void ShowWinScreen()
    {
        winnerBackground.SetActive(true);
        winnerLogo.SetActive(true);
        timeVictoryText.gameObject.SetActive(true);
        Texts.gameObject.SetActive(true);
        Back.gameObject.SetActive(true);
        Retry.gameObject.SetActive(true);
        if (endTime <= 60f)
        {
            star3.SetActive(true);
        }
        else if (endTime <= 80)
        {
            star2.SetActive(true);
        }
        else
        {
            star1.SetActive(true);
        }
    }

    string FormatTime(float timeInS)
    {
        int s = Mathf.FloorToInt(timeInS);
        int ms = Mathf.FloorToInt((timeInS - s) * 100);
        return string.Format("{0}.{1:00}s", s, ms);
    }
}