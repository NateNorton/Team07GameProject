﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeController : MonoBehaviour
{
    [SerializeField]
    private GameObject upgradeMenuCanvas;

    [SerializeField] private GameObject[] healthUpgradeBlocks;
    [SerializeField] private GameObject[] armourUpgradeBlocks;
    [SerializeField] private GameObject[] shieldUpgradeBlocks;
    [SerializeField] private GameObject[] shotSpeedUpgradeBlocks;
    [SerializeField] private GameObject[] turretUpgradeBlocks;
    [SerializeField] private GameObject[] airstrikeUpgradeBlocks;

    private bool isOpen;

    private int healthUpgradeLevel;
    private int armourUpgradeLevel;
    private int shieldUpgradeLevel;
    private int shotSpeedUpgradeLevel;
    private int turretUpgradeLevel;
    private int airstrikeUpgradeLevel;

    // Start is called before the first frame update
    private void Start()
    {
        // all upgrade levels start at 0
        healthUpgradeLevel = 0;
        armourUpgradeLevel = 0;
        shieldUpgradeLevel = 0;
        shotSpeedUpgradeLevel = 0;
        turretUpgradeLevel = 0;
        airstrikeUpgradeLevel = 0;
    }

    private void Update()
    {
        // use escape for the pause menu
        if (Input.GetKeyDown(KeyCode.U))
        {
            isOpen = !isOpen;

            if (isOpen)
            {
                openUpgradeMenu();
            }
            else
            {
                closeUpgradeMenu();
            }
        }
    }

    public void healthUpgradePressed()
    {
        // make sure that upgrade isn't fully upgraded
        if (healthUpgradeLevel < 3)
        {
            // check that player has enough currency to make purchase
            

            // increase upgrade level
            healthUpgradeLevel++;

            changeBlockColour(healthUpgradeLevel - 1, healthUpgradeBlocks);
        }
    }

    public void armourUpgradePressed()
    {
        // make sure that upgrade isn't fully upgraded
        if (armourUpgradeLevel < 3)
        {
            // increase upgrade level
            armourUpgradeLevel++;

            changeBlockColour(armourUpgradeLevel - 1, armourUpgradeBlocks);
        }
    }

    public void shieldUpgradePressed()
    {
        // make sure that upgrade isn't fully upgraded
        if (shieldUpgradeLevel < 3)
        {
            // increase upgrade level
            shieldUpgradeLevel++;

            changeBlockColour(shieldUpgradeLevel - 1, shieldUpgradeBlocks);
        }
    }

    public void shotSpeedUpgradePressed()
    {
        // make sure that upgrade isn't fully upgraded
        if (shotSpeedUpgradeLevel < 3)
        {
            // increase upgrade level
            shotSpeedUpgradeLevel++;

            changeBlockColour(shotSpeedUpgradeLevel - 1, shotSpeedUpgradeBlocks);
        }
    }

    public void turretUpgradePressed()
    {
        // make sure that upgrade isn't fully upgraded
        if (turretUpgradeLevel < 3)
        {
            // increase upgrade level
            turretUpgradeLevel++;

            changeBlockColour(turretUpgradeLevel - 1, turretUpgradeBlocks);
        }
    }

    public void airstrikeUpgradePressed()
    {
        // make sure that upgrade isn't fully upgraded
        if (airstrikeUpgradeLevel < 3)
        {
            // increase upgrade level
            airstrikeUpgradeLevel++;

            changeBlockColour(airstrikeUpgradeLevel - 1, airstrikeUpgradeBlocks);
        }
    }

    private void changeBlockColour(int blockPosition, GameObject[] blocks)
    {
        blocks[blockPosition]
            .GetComponent<Image>()
            .color = new Color32(47, 120, 39, 255);
    }

    private void openUpgradeMenu()
    {
        // pause the game
        Time.timeScale = 0;

        // open the upgrade menu
        upgradeMenuCanvas.SetActive(true);
    }

    private void closeUpgradeMenu()
    {
        // close the upgrade menu
        upgradeMenuCanvas.SetActive(false);

        // restart game
        Time.timeScale = 1;
    }

}
