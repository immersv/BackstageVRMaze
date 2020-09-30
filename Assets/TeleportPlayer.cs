using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    // to teleport player
    public GameObject player;

    public void OnTeleportPlayer()
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.6f, transform.position.z);
    }
}
