using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamController : MonoBehaviour
{
    GameObject player;
    
    void Start()
    {
      player = GameObject.FindWithTag("Player");
    }
    
    void FixedUpdate()
    {
      this.transform.position = new Vector3(
        player.transform.position.x,
        this.transform.position.y,
        player.transform.position.z
      );
    }
}
