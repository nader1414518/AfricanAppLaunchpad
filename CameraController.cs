using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public GameManager_ gm;
    public GameObject pauseBtn;
    
    void Update()
    {
      // if (gm.bIsDoneLoading)
      // {
      //   this.GetComponent<VideoPlayer>().Play();
      //   // gm.bIsDoneLoading = false;
      // }
      if (this.GetComponent<VideoPlayer>().isPaused)
      {
        this.GetComponent<VideoPlayer>().enabled = false;
        if (pauseBtn)
        {
          pauseBtn.SetActive(true);
        }
        SceneManager.LoadScene("Egypt", LoadSceneMode.Single);
      }
    }
}
