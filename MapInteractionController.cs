using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class MapInteractionController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public Texture2D selectionCursor;
    public Texture2D doneCursor;
    public CursorMode cursorMode = CursorMode.Auto;
    Vector2 hotspot = Vector2.zero;
    bool bIsRegionSelected = false;
    public GameManager_ gm;
    public GameObject mainCam;
    public GameObject pauseBtn;
    bool bIsDone = false;
    
    void Start()
    {
      this.GetComponent<Image>().color = Color.red;
    }
    
    void Update()
    {
      // Debug.Log(Input.mousePosition);
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
      // Debug.Log("Entered .... ");
      // this.GetComponent<Image>().color = Color.white;
      if (selectionCursor)
      {
        if (selectionCursor)
        {
          Cursor.SetCursor(selectionCursor, hotspot, cursorMode);
        }
      }
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
      // Debug.Log("Exit ..... ");
      Cursor.SetCursor(null, hotspot, cursorMode);
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
      // Debug.Log("Pointer Down .... ");
      if (ValidateSelection())
      {
        Debug.Log("Successfull ... ");
        // this.GetComponent<Image>().color = Color.white;
        if (doneCursor && !(bIsRegionSelected))
        {
          Cursor.SetCursor(doneCursor, hotspot, cursorMode);
          bIsRegionSelected = true;
          StartCoroutine(Delay());
        }
      }
    }
    
    IEnumerator Delay()
    {
      // Wait for the above amount of time then execute the code below 
      if (!(bIsDone))
      {
        yield return new WaitForSeconds(5.0f);
        Cursor.SetCursor(null, hotspot, cursorMode);
        if (gm)
        {
          gm.bIsDoneLoading = true;
          if (mainCam && gm.countriesTxt)
          {
            gm.countriesTxt.gameObject.SetActive(false);
            mainCam.GetComponent<VideoPlayer>().Play();
            if (pauseBtn)
            {
              pauseBtn.SetActive(false);
            }
          }
        }
        this.gameObject.SetActive(false);
        Debug.Log("Put Loading Screen Now .... ");
        bIsDone = true;
      }
      
    }
    
    bool ValidateSelection()
    {
      if ((Input.mousePosition.x > 980 && Input.mousePosition.x < 1090) && (Input.mousePosition.y > 650 && Input.mousePosition.y < 800))
      {
        return true;
      }
      else{
        return true;        
      }
    }
}
