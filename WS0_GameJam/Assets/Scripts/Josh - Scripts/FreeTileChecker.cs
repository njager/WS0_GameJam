using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeTileChecker : MonoBehaviour
{
    private GlobalController global;
    void Start()
    {
        global = GlobalController.instance;
    }

    public void FreeTileCheck()
    {
        // Tile Box 1
        if (global.freeTiles1 == 3)
        {
            global.tile1FreeTile1.SetActive(true);
            global.tile1FreeTile2.SetActive(true);
            global.tile1FreeTile3.SetActive(true);
        }
        if (global.freeTiles1 == 2)
        {
            global.tile1FreeTile1.SetActive(false);
            global.tile1FreeTile2.SetActive(true);
            global.tile1FreeTile3.SetActive(true);
        }
        if (global.freeTiles1 == 1)
        {
            global.tile1FreeTile1.SetActive(false);
            global.tile1FreeTile2.SetActive(false);
            global.tile1FreeTile3.SetActive(true);
        }
        if (global.freeTiles1 == 0)
        {
            global.tile1FreeTile1.SetActive(false);
            global.tile1FreeTile2.SetActive(false);
            global.tile1FreeTile3.SetActive(false);
        }

        // Tile Box 2
        if (global.freeTiles2 == 3)
        {
            global.tile2FreeTile1.SetActive(true);
            global.tile2FreeTile2.SetActive(true);
            global.tile2FreeTile3.SetActive(true);
        }
        if (global.freeTiles2 == 2)
        {
            global.tile2FreeTile1.SetActive(false);
            global.tile2FreeTile2.SetActive(true);
            global.tile2FreeTile3.SetActive(true);
        }
        if (global.freeTiles2 == 1)
        {
            global.tile2FreeTile1.SetActive(false);
            global.tile2FreeTile2.SetActive(false);
            global.tile2FreeTile3.SetActive(true);
        }
        if (global.freeTiles2 == 0)
        {
            global.tile2FreeTile1.SetActive(false);
            global.tile2FreeTile2.SetActive(false);
            global.tile2FreeTile3.SetActive(false);

        }
        // Tile Box 3
        if (global.freeTiles3 == 3)
        {
            global.tile3FreeTile1.SetActive(true);
            global.tile3FreeTile2.SetActive(true);
            global.tile3FreeTile3.SetActive(true);
        }
        if (global.freeTiles3 == 2)
        {
            global.tile3FreeTile1.SetActive(false);
            global.tile3FreeTile2.SetActive(true);
            global.tile3FreeTile3.SetActive(true);
        }
        if (global.freeTiles3 == 1)
        {
            global.tile3FreeTile1.SetActive(false);
            global.tile3FreeTile2.SetActive(false);
            global.tile3FreeTile3.SetActive(true);
        }
        if (global.freeTiles3 == 0)
        {
            global.tile3FreeTile1.SetActive(false);
            global.tile3FreeTile2.SetActive(false);
            global.tile3FreeTile3.SetActive(false);
        }
        // Tile Box 4
        if (global.freeTiles4 == 3)
        {
            global.tile4FreeTile1.SetActive(true);
            global.tile4FreeTile2.SetActive(true);
            global.tile4FreeTile3.SetActive(true);
        }
        if (global.freeTiles4 == 2)
        {
            global.tile4FreeTile1.SetActive(false);
            global.tile4FreeTile2.SetActive(true);
            global.tile4FreeTile3.SetActive(true);
        }
        if (global.freeTiles4 == 1)
        {
            global.tile4FreeTile1.SetActive(false);
            global.tile4FreeTile2.SetActive(false);
            global.tile4FreeTile3.SetActive(true);
        }
        if (global.freeTiles4 == 0)
        {
            global.tile4FreeTile1.SetActive(false);
            global.tile4FreeTile2.SetActive(false);
            global.tile4FreeTile3.SetActive(false);
        }
        // Tile Box 5
        if (global.freeTiles5 == 3)
        { 
            global.tile5FreeTile1.SetActive(true);
            global.tile5FreeTile2.SetActive(true);
            global.tile5FreeTile3.SetActive(true);
        }
        if (global.freeTiles5 == 2)
        {
            global.tile5FreeTile1.SetActive(false);
            global.tile5FreeTile2.SetActive(true);
            global.tile5FreeTile3.SetActive(true);
        }
        if (global.freeTiles5 == 1)
        {
            global.tile5FreeTile1.SetActive(false);
            global.tile5FreeTile2.SetActive(false);
            global.tile5FreeTile3.SetActive(true);
        }
        if (global.freeTiles5 == 0)
        {
            global.tile5FreeTile1.SetActive(false);
            global.tile5FreeTile2.SetActive(false);
            global.tile5FreeTile3.SetActive(false);
        }
        // Tile Box 6
        if (global.freeTiles6 == 3)
        {
            global.tile6FreeTile1.SetActive(true);
            global.tile6FreeTile2.SetActive(true);
            global.tile6FreeTile3.SetActive(true);
        }
        if (global.freeTiles6 == 2)
        {
            global.tile6FreeTile1.SetActive(false);
            global.tile6FreeTile2.SetActive(true);
            global.tile6FreeTile3.SetActive(true);
        }
        if (global.freeTiles6 == 1)
        {
            global.tile6FreeTile1.SetActive(false);
            global.tile6FreeTile2.SetActive(false);
            global.tile6FreeTile3.SetActive(true);
        }
        if (global.freeTiles6 == 0)
        {
            global.tile6FreeTile1.SetActive(false);
            global.tile6FreeTile2.SetActive(false);
            global.tile6FreeTile3.SetActive(false);
        }
        // Tile Box 7
        if (global.freeTiles7 == 3)
        {
            global.tile7FreeTile1.SetActive(true);
            global.tile7FreeTile2.SetActive(true);
            global.tile7FreeTile3.SetActive(true);
        }
        if (global.freeTiles7 == 2)
        {
            global.tile7FreeTile1.SetActive(false);
            global.tile7FreeTile2.SetActive(true);
            global.tile7FreeTile3.SetActive(true);
        }
        if (global.freeTiles7 == 1)
        {
            global.tile7FreeTile1.SetActive(false);
            global.tile7FreeTile2.SetActive(false);
            global.tile7FreeTile3.SetActive(true);
        }
        if (global.freeTiles7 == 0)
        {
            global.tile7FreeTile1.SetActive(false);
            global.tile7FreeTile2.SetActive(false);
            global.tile7FreeTile3.SetActive(false);
        }
    }
}