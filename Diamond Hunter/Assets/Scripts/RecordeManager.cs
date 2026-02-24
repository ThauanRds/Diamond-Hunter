using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordeManager : MonoBehaviour
{
    public static void SaveGameTime(float time)
    {
        // Buscando um registro de tempo na memória! Caso não haja, o valor padrão é 0.
        float currentRecorde = PlayerPrefs.GetFloat("MelhorTempo");

        // Se o tempo atual for maior que zero, existe um tempo registrado
        if (currentRecorde > 0)
        {
            // Sobreescrevendo o tempo registrado apenas se o tempo atual for menor (melhor) que o tempo registrado
            if (time < currentRecorde)
            {
                PlayerPrefs.SetFloat("MelhorTempo", time);
            }
        }
        else  // Se o tempo atual for zero, não existe um tempo registrado
        {
            // Salvando o tempo atual como o melhor tempo (primeiro registro)
            PlayerPrefs.SetFloat("MelhorTempo", time);
        }
    }

    public static float GetBestTime()
    {
        // Buscando um registro de tempo na memória! Caso não haja, o valor padrão é 0.
        return PlayerPrefs.GetFloat("MelhorTempo");
    }
}
