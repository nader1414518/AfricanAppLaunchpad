using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsCtrl : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public List<GameObject> hideWhenPaused;
    public List<GameObject> hideWhenInInventory;
    public GameObject inventoryPanel;
    
    void Start()
    {
      Time.timeScale = 1;
      if (pauseMenuPanel)
      {
        pauseMenuPanel.SetActive(false);
      }
      if (inventoryPanel)
      {
        inventoryPanel.SetActive(false);
      }
    }
    
    public void ShowInventory()
    {
      if (inventoryPanel)
      {
        inventoryPanel.SetActive(true);
      }
      for (int i = 0; i < hideWhenInInventory.Count; i++)
      {
        if (hideWhenInInventory[i])
        {
          hideWhenInInventory[i].SetActive(false);
        }
      }
    }
    
    public void CloseInventory()
    {
      if (inventoryPanel)
      {
        inventoryPanel.SetActive(false);
      }
      for (int i = 0; i < hideWhenInInventory.Count; i++)
      {
        if (hideWhenInInventory[i])
        {
          hideWhenInInventory[i].SetActive(true);
        }
      }
    }
    
    public void PauseGame()
    {
      Time.timeScale = 0;
      if (pauseMenuPanel)
      {
        pauseMenuPanel.SetActive(true);
        for (int i = 0; i < hideWhenPaused.Count; i++)
        {
          if (hideWhenPaused[i])
          {
            hideWhenPaused[i].SetActive(false);
          }
        }
      }
    }
    
    public void ResumeGame()
    {
      Time.timeScale = 1;
      if (pauseMenuPanel)
      {
        pauseMenuPanel.SetActive(false);
        for (int i = 0; i < hideWhenPaused.Count; i++)
        {
          if (hideWhenPaused[i])
          {
            hideWhenPaused[i].SetActive(true);
          }
        }
      }
    }
    
    public void BackToMainMenu()
    {
      SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    
    public void StartGame()
    {
      SceneManager.LoadScene("DesignerMode", LoadSceneMode.Single);
    }
    
    public void QuitGame()
    {
      Application.Quit();
    }
}
