using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkedSpawner : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn;
    [SerializeField] GameObject spawnLocation;
    [SerializeField] string triggerTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            PhotonNetwork.Instantiate(objectToSpawn.name, spawnLocation.transform.position, spawnLocation.transform.rotation);
        }
    }
}
