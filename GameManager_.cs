using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GameManager_ : MonoBehaviour
{
    GameObject player;
    public List<string> countries;
    public List<GameObject> parchments;
    public Text countriesTxt;
    public GameObject rollBtn;
    public GameObject africaMap;
    bool bIsDiceRolled = false;
    bool bCountrySelected = false;
    public bool bIsDoneLoading = false;
    public bool bIsAtumParchmentAcquired = false;
    public bool bIsShuParchmentAcquired = false;
    public bool bIsGebParchmentAcquired = false;
    public bool bIsNutParchmentAcquired = false;
    public bool bIsIsisParchmentAcquired = false;
    public bool bIsOsirisParchmentAcquired = false;
    public bool bIsTefnutParchmentAcquired = false;
    public bool bIsSethParchmentAcquired = false;
    public Text missionTxt;
    
    
    public void RollDice()
    {
      bIsDiceRolled = true;
    }
    
    void Start()
    {
      player = GameObject.FindWithTag("Player");
      
      if (africaMap)
      {
        africaMap.SetActive(false);
      }
      if (missionTxt)
      {
        missionTxt.text = "Find Atum's Parchment ... ";
      }
      for (int i = 0; i < parchments.Count; i++)
      {
        if (parchments[i])
        {
          if (i == 0)
          {
            parchments[i].SetActive(true);
          }
          else{
            parchments[i].SetActive(false);
          }
        }
      }
      if (bIsAtumParchmentAcquired)
      {
        if (bIsShuParchmentAcquired)
        {
          if (bIsGebParchmentAcquired)
          {
            if (bIsNutParchmentAcquired)
            {
              if (bIsTefnutParchmentAcquired)
              {
                if (bIsIsisParchmentAcquired)
                {
                  if (bIsOsirisParchmentAcquired)
                  {
                    if (bIsSethParchmentAcquired)
                    {
                      if (player.GetComponent<PlayerController>().displayRocks[7].GetComponent<VideoPlayer>().isPaused)
                      {
                        Debug.Log("Cinematic 8 is done being displayed .... ");
                      }
                    }
                    else{
                      if (player.GetComponent<PlayerController>().displayRocks[6].GetComponent<VideoPlayer>().isPaused)
                      {
                        Debug.Log("Cinematic 7 is done being displayed .... ");
                      }
                    }
                  }
                  else{
                    if (player.GetComponent<PlayerController>().displayRocks[5].GetComponent<VideoPlayer>().isPaused)
                    {
                      Debug.Log("Cinematic 6 is done being displayed .... ");
                    }
                  }
                }
                else{
                  if (player.GetComponent<PlayerController>().displayRocks[4].GetComponent<VideoPlayer>().isPaused)
                  {
                    Debug.Log("Cinematic 5 is done being displayed .... ");
                  }
                }
              }
              else{
                if (player.GetComponent<PlayerController>().displayRocks[3].GetComponent<VideoPlayer>().isPaused)
                {
                  Debug.Log("Cinematic 4 is done being displayed .... ");
                }
              }
            }
            else{
              if (player.GetComponent<PlayerController>().displayRocks[2].GetComponent<VideoPlayer>().isPaused)
              {
                Debug.Log("Cinematic 3 is done being displayed .... ");
              }
            }
          }
          else{
            if (player.GetComponent<PlayerController>().displayRocks[1].GetComponent<VideoPlayer>().isPaused)
            {
              Debug.Log("Cinematic 2 is done being displayed .... ");
            }
          }
        }
        else{
          if (player.GetComponent<PlayerController>().displayRocks[0].GetComponent<VideoPlayer>().isPaused)
          {
            Debug.Log("Cinematic 1 is done being displayed .... ");
          }
        }
      }
    }
    
    void Update()
    {
      if (bIsDiceRolled && (int)Time.frameCount%10 == 0)
      {
        if (rollBtn)
        {
          rollBtn.SetActive(false);
        }
        if (countriesTxt)
        {
          if (countriesTxt.text == "Egypt" && !(bCountrySelected))
          {
            Debug.Log("Egypt Selected ... ");
            // if (rollBtn)
            // {
            //   rollBtn.SetActive(true);
            // }
            bCountrySelected = true;
            if (africaMap)
            {
              africaMap.SetActive(true);
            }
          }
          else if (bCountrySelected){
            return;
          }
          else{
            countriesTxt.text = countries[Random.Range(0, countries.Count-1)];
          }
        }
        
        
      }
      
      
      
      // if (missionTxt && bIsShuParchmentAcquired && bIsGebParchmentAcquired && bIsAtumParchmentAcquired && bIsTefnutParchmentAcquired && bIsNutParchmentAcquired && bIsOsirisParchmentAcquired && bIsIsisParchmentAcquired)
      // {
      //   missionTxt.text = "Find Seth's Parchment ... ";
      // }
      // else if (missionTxt && bIsShuParchmentAcquired && bIsGebParchmentAcquired && bIsAtumParchmentAcquired && bIsTefnutParchmentAcquired && bIsNutParchmentAcquired && bIsOsirisParchmentAcquired)
      // {
      //   missionTxt.text = "Find Isis's Parchment ... ";
      // }
      // else if (missionTxt && bIsShuParchmentAcquired && bIsGebParchmentAcquired && bIsAtumParchmentAcquired && bIsTefnutParchmentAcquired && bIsNutParchmentAcquired)
      // {
      //   missionTxt.text = "Find Osiris's Parchment ... ";
      // }
      // else if (missionTxt && bIsShuParchmentAcquired && bIsAtumParchmentAcquired && bIsTefnutParchmentAcquired && bIsGebParchmentAcquired)
      // {
      //   missionTxt.text = "Find Nut's Parchment ... ";
      // }
      // else if (missionTxt && bIsShuParchmentAcquired && bIsAtumParchmentAcquired && bIsTefnutParchmentAcquired)
      // {
      //   missionTxt.text = "Find Geb's Parchment ... ";
      // }
      // else if (missionTxt && bIsShuParchmentAcquired && bIsAtumParchmentAcquired)
      // {
      //   missionTxt.text = "Find Tefnut's Parchment ... ";
      // }
      // else if (missionTxt && bIsAtumParchmentAcquired)
      // {
      //   missionTxt.text = "Find Shu's Parchment ... ";
      // }
      // else{
      //   if (missionTxt)
      //   {
      //     missionTxt.text = "Find Atum's Parchment ... ";
      //   }
      // }
    }
    
}
