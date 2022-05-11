using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretMoney regularTuret;
    public TurretMoney missileTurret;
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectRegularTurret ()
    {
        Debug.Log("Turret Selected");
        buildManager.SelectTurretToBuild(regularTuret);
    }

    public void SelectMissileTurret()
    {
        Debug.Log("Missile Turret Selected");
        buildManager.SelectTurretToBuild(missileTurret);
    }
}
