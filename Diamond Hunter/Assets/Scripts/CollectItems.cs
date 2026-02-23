using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectItems : MonoBehaviour
{
    [SerializeField] private int diamondsCollected;
    [SerializeField] private PlayerUI playerUI;

    [SerializeField] private UnityEvent onEndGame;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Collectable")
        {
            diamondsCollected++;
            playerUI.UpdateDiamondText(diamondsCollected, 5);
            Destroy(hit.gameObject);

            if (diamondsCollected >= 5)
            {
                onEndGame.Invoke();
            }
        }
    }
}
