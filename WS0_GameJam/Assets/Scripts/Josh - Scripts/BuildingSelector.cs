using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class BuildingSelector : MonoBehaviour
{
    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance;
    }

    public void SelectedBuilding()
    {
        Debug.Log("Building Selected");
        global.menuCanvas.SetActive(true);
        global.gamePaused = true;
        global.PauseGame();
    }

    public void ConfirmButton()
    {
        Debug.Log("Building Confirmed");
        global.mapContainer.SetActive(false);
        global.menuCanvas.SetActive(false);
        global.testAudio2.Play();
        global.gamePaused = false;
        global.PauseGame();
        ActivateTilebox(); 
    }

    public void BackButton()
    {
        Debug.Log("Building Not Selected");
        global.menuCanvas.SetActive(false);
        global.gamePaused = false;
        global.PauseGame();
    }


    public void ActivateTilebox()
    {
        global.mapContainer.SetActive(false);
        global.transparentCanvas.SetActive(true);
        global.tileBox1.SetActive(true);
        global.freeTileUI.SetActive(true);
        global.characterUI.SetActive(true);
        global.dialogueCanvas.SetActive(true);
    }

    public void DeactivateTilebox()
    {
        global.mapContainer.SetActive(true);
        global.transparentCanvas.SetActive(false);
        global.tileBox1.SetActive(false);
        global.freeTileUI.SetActive(false);
        global.characterUI.SetActive(false);
        global.dialogueCanvas.SetActive(false);
    }
}
