using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;

    buildManager buildManager;
    
    void Start()
    {
        buildManager = buildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    
    public void SelectMissileLauncher()
    {
        Debug.Log("Missile Launcher Selected");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
    
    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
    
}
