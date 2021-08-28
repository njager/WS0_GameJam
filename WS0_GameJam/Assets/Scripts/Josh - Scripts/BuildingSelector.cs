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
        global.menuCanvas.SetActive(true);
    }

    public void ConfirmButton()
    {
        global.mapContainer.SetActive(false);
        global.menuCanvas.SetActive(false);
        global.testAudio2.Play(); 
    }

    public void BackButton()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
