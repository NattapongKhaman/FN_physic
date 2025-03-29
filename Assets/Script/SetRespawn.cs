using System;
using Unity.VisualScripting;
using UnityEngine;

public class SetRespawn : MonoBehaviour
{
    public GameObject respawnPoint;
    public PlayerCon respawnplayer;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Save Respawn");
            respawnplayer.respawnPoint = respawnPoint;
            
        }
    }
}
