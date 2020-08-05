using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public GameObject player;
    public float smoothTime = 0.3f;
    Vector3 velocity = Vector3.zero;
    public float yOffset;
    public float zOffset;
    
    // public float speedH = 2.0f;
    // public float speedV = 2.0f;
    // 
    // private float yaw = 0.0f;
    // private float pitch = 0.0f;
    
    void Start()
    {
      //player = GameObject.FindWithTag("Player");
    }
    
    void FixedUpdate()
    {
      Vector3 target = new Vector3(
        player.transform.position.x,
        player.transform.position.y+yOffset,
        player.transform.position.z+zOffset
      );
      
      this.transform.position = Vector3.SmoothDamp(this.transform.position, target, ref velocity, smoothTime);
      // this.transform.LookAt(player.transform, Vector3.up);
    }
    
    // void Update()
    // {
    //   yaw += speedH * Input.GetAxis("Mouse X");
    //   pitch -= speedV * Input.GetAxis("Mouse Y");
    // 
    //   this.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    // }
}
