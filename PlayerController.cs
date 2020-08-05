using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager_ gm;
    Animator animator;
    public float speed;
    public float rotationSpeed;
    public Item atumParchment;
    public Item shuParchment;
    public Item tefnutParchment;
    public Item gebParchment;
    public Item nutParchment;
    public Item osirisParchment;
    public Item isisParchment;
    public Item sethParchment;
    public InventoryController invCtrl;
    public GameObject displayRock;
    public List<GameObject> displayRocks;
    
    void Start()
    {
      animator = this.GetComponent<Animator>();
      if (animator)
      {
        animator.SetFloat("Speed", 0.0f);
      }
    }
    
    void FixedUpdate()
    {
      float ver = Input.GetAxis("Vertical");
      float hor = Input.GetAxis("Horizontal");
      
      Vector3 playerMovement = new Vector3 (hor, 0f, ver) * speed * Time.deltaTime;
  		Quaternion lookRotation = Quaternion.LookRotation (playerMovement, Vector3.up);
  		float step = rotationSpeed * Time.deltaTime;
  		this.transform.rotation = Quaternion.RotateTowards (lookRotation, this.transform.rotation, step);
      
      this.GetComponent<Rigidbody>().AddForce(playerMovement);
      
      if (hor != 0 || ver != 0)
      {
        if (animator)
        {
          animator.SetFloat("Speed", 1.0f);
        }
      }
      else{
        if (animator)
        {
          animator.SetFloat("Speed", 0.0f);
        }
      }
    }
    
    void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.tag == "AtumParchment")
      {
        if (gm)
        {
          gm.bIsAtumParchmentAcquired = true;
          if (gm.missionTxt)
          {
            gm.missionTxt.text = "Find Shu's Parchment ... ";
          }
          for (int i = 0; i < gm.parchments.Count; i++)
          {
            if (gm.parchments[i])
            {
              if (i < 2)
              {
                gm.parchments[i].SetActive(true);
              }
              else{
                gm.parchments[i].SetActive(false);
              }
            }
          }
        }
        if (invCtrl)
        {
          if (atumParchment)
          {
            invCtrl.AddItem(atumParchment);
          }
        }
        if (displayRock)
        {
          GameObject displayRockObj1 = GameObject.Instantiate<GameObject>(displayRock);
          displayRockObj1.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y+2,
            this.transform.position.z+4
          );
          displayRocks.Add(displayRockObj1);
        }
        GameObject.Destroy(collision.gameObject);
      }
      if (collision.gameObject.tag == "ShuParchment")
      {
        if (gm)
        {
          gm.bIsShuParchmentAcquired = true;
          if (gm.missionTxt)
          {
            gm.missionTxt.text = "Find Tefnut's Parchment ... ";
          }
          for (int i = 0; i < gm.parchments.Count; i++)
          {
            if (gm.parchments[i])
            {
              if (i < 3)
              {
                gm.parchments[i].SetActive(true);
              }
              else{
                gm.parchments[i].SetActive(false);
              }
            }
          }
        }
        if (invCtrl)
        {
          if (shuParchment)
          {
            invCtrl.AddItem(shuParchment);
          }
        }
        if (displayRock)
        {
          GameObject displayRockObj2 = GameObject.Instantiate<GameObject>(displayRock);
          displayRockObj2.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y+2,
            this.transform.position.z+4
          );
          displayRocks.Add(displayRockObj2);
        }
        GameObject.Destroy(collision.gameObject);
      }
      if (collision.gameObject.tag == "TefnutParchment")
      {
        if (gm)
        {
          gm.bIsTefnutParchmentAcquired = true;
          if (gm.missionTxt)
          {
            gm.missionTxt.text = "Find Geb's Parchment ... ";
          }
          for (int i = 0; i < gm.parchments.Count; i++)
          {
            if (gm.parchments[i])
            {
              if (i < 4)
              {
                gm.parchments[i].SetActive(true);
              }
              else{
                gm.parchments[i].SetActive(false);
              }
            }
          }
        }
        if (invCtrl)
        {
          if (tefnutParchment)
          {
            invCtrl.AddItem(tefnutParchment);
          }
        }
        if (displayRock)
        {
          GameObject displayRockObj3 = GameObject.Instantiate<GameObject>(displayRock);
          displayRockObj3.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y+2,
            this.transform.position.z+4
          );
          displayRocks.Add(displayRockObj3);
        }
        GameObject.Destroy(collision.gameObject);
      }
      if (collision.gameObject.tag == "GebParchment")
      {
        if (gm)
        {
          gm.bIsGebParchmentAcquired = true;
          if (gm.missionTxt)
          {
            gm.missionTxt.text = "Find Nut's Parchment ... ";
          }
          for (int i = 0; i < gm.parchments.Count; i++)
          {
            if (gm.parchments[i])
            {
              if (i < 5)
              {
                gm.parchments[i].SetActive(true);
              }
              else{
                gm.parchments[i].SetActive(false);
              }
            }
          }
        }
        if (invCtrl)
        {
          if (gebParchment)
          {
            invCtrl.AddItem(gebParchment);
          }
        }
        if (displayRock)
        {
          GameObject displayRockObj4 = GameObject.Instantiate<GameObject>(displayRock);
          displayRockObj4.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y+2,
            this.transform.position.z+4
          );
          displayRocks.Add(displayRockObj4);
        }
        GameObject.Destroy(collision.gameObject);
      }
      if (collision.gameObject.tag == "NutParchment")
      {
        if (gm)
        {
          gm.bIsNutParchmentAcquired = true;
          if (gm.missionTxt)
          {
            gm.missionTxt.text = "Find Osiris's Parchment ... ";
          }
          for (int i = 0; i < gm.parchments.Count; i++)
          {
            if (gm.parchments[i])
            {
              if (i < 6)
              {
                gm.parchments[i].SetActive(true);
              }
              else{
                gm.parchments[i].SetActive(false);
              }
            }
          }
        }
        if (invCtrl)
        {
          if (nutParchment)
          {
            invCtrl.AddItem(nutParchment);
          }
        }
        if (displayRock)
        {
          GameObject displayRockObj5 = GameObject.Instantiate<GameObject>(displayRock);
          displayRockObj5.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y+2,
            this.transform.position.z+4
          );
          displayRocks.Add(displayRockObj5);
        }
        GameObject.Destroy(collision.gameObject);
      }
      if (collision.gameObject.tag == "OsirisParchment")
      {
        if (gm)
        {
          gm.bIsOsirisParchmentAcquired = true;
          if (gm.missionTxt)
          {
            gm.missionTxt.text = "Find Isis's Parchment ... ";
          }
          for (int i = 0; i < gm.parchments.Count; i++)
          {
            if (gm.parchments[i])
            {
              if (i < 7)
              {
                gm.parchments[i].SetActive(true);
              }
              else{
                gm.parchments[i].SetActive(false);
              }
            }
          }
        }
        if (invCtrl)
        {
          if (osirisParchment)
          {
            invCtrl.AddItem(osirisParchment);
          }
        }
        if (displayRock)
        {
          GameObject displayRockObj6 = GameObject.Instantiate<GameObject>(displayRock);
          displayRockObj6.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y+2,
            this.transform.position.z+4
          );
          displayRocks.Add(displayRockObj6);
        }
        GameObject.Destroy(collision.gameObject);
      }
      if (collision.gameObject.tag == "IsisParchment")
      {
        if (gm)
        {
          gm.bIsIsisParchmentAcquired = true;
          if (gm.missionTxt)
          {
            gm.missionTxt.text = "Find Seth's Parchment ... ";
          }
          for (int i = 0; i < gm.parchments.Count; i++)
          {
            if (gm.parchments[i])
            {
              if (i < 8)
              {
                gm.parchments[i].SetActive(true);
              }
              else{
                gm.parchments[i].SetActive(false);
              }
            }
          }
        }
        if (invCtrl)
        {
          if (isisParchment)
          {
            invCtrl.AddItem(isisParchment);
          }
        }
        if (displayRock)
        {
          GameObject displayRockObj7 = GameObject.Instantiate<GameObject>(displayRock);
          displayRockObj7.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y+2,
            this.transform.position.z+4
          );
          displayRocks.Add(displayRockObj7);
        }
        GameObject.Destroy(collision.gameObject);
      }
      if (collision.gameObject.tag == "SethParchment")
      {
        if (gm)
        {
          gm.bIsSethParchmentAcquired = true;
        }
        for (int i = 0; i < gm.parchments.Count; i++)
        {
          if (gm.parchments[i])
          {
            if (i < 8)
            {
              gm.parchments[i].SetActive(true);
            }
            else{
              gm.parchments[i].SetActive(false);
            }
          }
        }
        if (invCtrl)
        {
          if (sethParchment)
          {
            invCtrl.AddItem(sethParchment);
          }
        }
        if (displayRock)
        {
          GameObject displayRockObj8 = GameObject.Instantiate<GameObject>(displayRock);
          displayRockObj8.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y+2,
            this.transform.position.z+4
          );
          displayRocks.Add(displayRockObj8);
        }
        GameObject.Destroy(collision.gameObject);
      }
    }
}
