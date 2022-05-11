using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColour;
    public Vector3 positionOffset;

    public GameObject turret;

    private Renderer rend;
    private Color startColour;


    BuildManager buildManager;
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColour = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
    void OnMouseEnter ()
    {
        if (!buildManager.CanBuild)
            return;
        rend.material.color = hoverColour;
    }

    void OnMouseDown()
    {
        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("BUILD");
            return;
        }

        buildManager.BuildTurretOn(this);
    }

    void OnMouseExit()
    {
        rend.material.color = startColour;
    }
}
