using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_Text recordeText;

    private void Start()
    {
        float recorde = RecordeManager.GetBestTime();
        if(recorde > 0)  // puxando o recorde salvo, se for maior que 0, mostra o recorde
        {
            recordeText.text = "Melhor tempo: " + recorde.ToString("00") + "s";
        }
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
