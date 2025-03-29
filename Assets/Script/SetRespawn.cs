using System;
using Unity.VisualScripting;
using UnityEngine;

public class SetRespawn : MonoBehaviour
{
    public GameObject respawnPoint;
    public PlayerCon respawnplayer;
    public int Level;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Save Respawn");
            respawnplayer.respawnPoint = respawnPoint;
            respawnplayer.currentMap = Level ;

        }
    }
}
