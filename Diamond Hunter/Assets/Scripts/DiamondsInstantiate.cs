using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondsInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject diamondPrefab;
    [SerializeField] private Transform[] spawnPoints;
    private int numberOfDiamonds = 5;


    // Start is called before the first frame update
    void Start()
    {
        // Criando os diamantes a partir de pontos fixos de spawn
        for (int i = 0; i < numberOfDiamonds; i ++)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(diamondPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
        }

        //// Criando os diamantes de forma 100% aleatória! Sem pontos fixos de spawn
        //for (int i = 0; i < numberOfDiamonds; i++)
        //{
        //    // Seleciona uma posição aleatória dentro dos limites do cenário
        //    float posX = Random.Range(-33f, 160);
        //    float posZ = Random.Range(-33f, 160);

        //    // Instancia o diamante na posição aleatória e desce o diamante caso ele tenha sido instanciado muito alto
        //    Instantiate(diamondPrefab, new Vector3(posX, 100f, posZ), Quaternion.identity);
        //}   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
