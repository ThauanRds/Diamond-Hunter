using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    [SerializeField] private int diamondsCollected;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Collectable")
        {
            diamondsCollected++;
            Destroy(hit.gameObject);
        }
    }
}
