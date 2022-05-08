using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    public GameObject turretnormalPrefab; 
    private GameObject buildTurret;
    public GameObject anotherturretPrefab;
    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogError("Build");
            return;
        }
        instance = this;
    }
    

   
    public GameObject getbuildTurret ()
    {
        return buildTurret;
    }

    public void SetTurretToBuild (GameObject turret)
    {
        buildTurret = turret;
    }
}
