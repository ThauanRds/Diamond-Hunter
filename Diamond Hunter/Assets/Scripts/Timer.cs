using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timeOfGame;
    [SerializeField] private PlayerUI playerUI;

    // Update is called once per frame
    void Update()
    {
        timeOfGame += Time.deltaTime;
        playerUI.UpdateTimerText(timeOfGame);
    }
}
