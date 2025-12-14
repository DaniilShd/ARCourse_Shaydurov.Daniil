using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update

    protected virtual bool IsRightCollision(GameObject collisionGo)
    {
        var playerData = collisionGo.GetComponent<PlayerData>();
        return playerData != null;
        
    }

    // protected abstract void DoEffects();

    private void OnTriggerEnter(Collider other)
    {
        if(IsRightCollision(other.gameObject))
        {
            // DoEffects();
        }
    }
}
