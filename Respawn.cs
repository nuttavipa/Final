using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{
   [SerializeField] private Transform player;
   [SerializeField] private Transform respawnPoint;

    void OntriggerEnter(Collider other)
    {
       player.transform.position = respawnPoint.transform.position;
    }
}
