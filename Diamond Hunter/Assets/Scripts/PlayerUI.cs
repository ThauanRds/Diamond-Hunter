using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TMP_Text diamondText;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text finishTime;
    [SerializeField] private GameObject finishPanel;

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
}
