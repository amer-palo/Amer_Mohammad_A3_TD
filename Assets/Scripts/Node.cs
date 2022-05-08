using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColour;
    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;
    private Color startColour;

    BuildManager buildManager;
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColour = rend.material.color;

        buildManager = BuildManager.instance;
    }
    void OnMouseEnter ()
    {
        if (buildManager.getbuildTurret() == null)
            return;
        rend.material.color = hoverColour;
    }

    void OnMouseDown()
    {
        if (buildManager.getbuildTurret() == null)
            return;

        if (turret != null)
        {
            Debug.Log("BUILD");
            return;
        }

        GameObject buildTurret = buildManager.getbuildTurret();
        turret = (GameObject)Instantiate(buildTurret, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseExit()
    {
        rend.material.color = startColour;
    }
}
