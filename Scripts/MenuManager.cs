using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public int menuID = 0;
    public GameObject[] InfoCanvasPanels;
    public GameObject FanInfoPanel;
    public GameObject SDWInfoPanel;
    public GameObject SUPInfoPanel;
    public GameObject GearInfoPanel;
    public GameObject GlassInfoPanel;
    //Called when ray hits this object

    void Start()
    {
        InfoCanvasPanels = GameObject.FindGameObjectsWithTag("InfoCanvas");
        FanInfoPanel = GameObject.Find("FanInfo");
        SDWInfoPanel = GameObject.Find("SDWInfo");
        SUPInfoPanel = GameObject.Find("SUPInfo");
        GearInfoPanel = GameObject.Find("GearInfo");
        GlassInfoPanel = GameObject.Find("GlassInfo");

        switchToMenu(menuID);
    }

    void Update()
    {

    }

    public void switchToMenu(int menuID)
    {
        foreach (GameObject panel in InfoCanvasPanels)
        {
            panel.gameObject.GetComponent<Renderer>().enabled = false;
            panel.gameObject.SetActive(false);
            Debug.Log(panel.name);
        }

        switch (menuID)
        {
            case 0:
                FanInfoPanel.gameObject.SetActive(true);
                break;
            case 1:
                SDWInfoPanel.gameObject.SetActive(true);
                break;
            case 2:
                SUPInfoPanel.gameObject.SetActive(true);
                break;
            case 3:
                GearInfoPanel.gameObject.SetActive(true);
                break;
            case 4:
                GlassInfoPanel.gameObject.SetActive(true);
                break;
        }
    }
}
