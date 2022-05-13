using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

     
    private TurretMoney buildTurret;
    
    
    public bool CanBuild { get { return buildTurret != null; } }
    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogError("Build");
            return;
        }
        instance = this;
    }
   

   public void BuildTurretOn (Node node)
   {
        if (PlayerStats.Money < buildTurret.cost)
        {
            Debug.Log("Not Enough Money");
            return;
        }

        PlayerStats.Money -= buildTurret.cost;

        GameObject turret = Instantiate(buildTurret.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        Debug.Log("Turret Built! Money left: " + PlayerStats.Money);
   }

    public void SelectTurretToBuild (TurretMoney turret)
    {
        buildTurret = turret;
    }
}
