using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TMP_Text diamondText;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text finishTime;
    [SerializeField] private GameObject finishPanel;
    [SerializeField] private GameObject pausePanel;

    public void UpdateDiamondText(int diamondsCollected, int totalDiamonds)
    {
        diamondText.text = diamondsCollected + " / " + totalDiamonds;
    }

    public void UpdateTimerText(float time)
    {
        // Passando para o contador que eu só quero que mostre números inteiros
        timerText.text = time.ToString("00") + "s";
    }

    public void ActivatePanel()
    {
        finishPanel.SetActive(true);
        finishTime.text = timerText.text;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void EndGame()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(0);
    }
}
