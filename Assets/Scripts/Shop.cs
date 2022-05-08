using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void BuyRegularTurret ()
    {
        Debug.Log("Turret Selected");
        buildManager.SetTurretToBuild(buildManager.turretnormalPrefab);
    }

    public void AnotherRegularTurret()
    {
        Debug.Log("Another Turret Selected");
        buildManager.SetTurretToBuild(buildManager.anotherturretPrefab);
    }
}
