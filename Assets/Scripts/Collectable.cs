using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode; 

public class Collectable : NetworkBehaviour 
{
    private void OnTriggerEnter(Collider other)
    {
        if (IsServer && transform.parent != other.transform && other.tag == "Player")
        {
            transform.parent = other.transform;
        }
    }
}
