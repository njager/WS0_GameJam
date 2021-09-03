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
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles1 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles1 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }


        // Tile Box 2
        if (global.freeTiles2 == 3)
        {
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles2 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles2 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }


        // Tile Box 3
        if (global.freeTiles3 == 3)
        {
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles3 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles3 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }

        // Tile Box 4
        if (global.freeTiles4 == 3)
        {
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles4 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles4 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }

        // Tile Box 5
        if (global.freeTiles5 == 3)
        {
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles5 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles5 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }

        // Tile Box 6
        if (global.freeTiles6 == 3)
        {
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles6 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles6 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }

        // Tile Box 7
        if (global.freeTiles7 == 3)
        {
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles7 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles7 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }
        // Tile Box 8

        if (global.freeTiles8 == 3)
        {
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles8 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles8 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }

        // Tile Box 9
        if (global.freeTiles9 == 3)
        {
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }


        if (global.freeTiles9 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles9 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }

        // Tile Box 10
        if (global.freeTiles10 == 3)
        {
            global.freeTile1.SetActive(true);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
        }
        if (global.freeTiles10 == 2)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(true);
            global.freeTile3.SetActive(true);
}
        if (global.freeTiles10 == 1)
        {
            global.freeTile1.SetActive(false);
            global.freeTile2.SetActive(false);
            global.freeTile3.SetActive(true);
        }
    }

    public void CheckFreeTile1()
    {
        global.freeTiles1--;
    }

    public void CheckFreeTile2()
    {
        global.freeTiles2--;
    }

    public void CheckFreeTile3()
    {
        global.freeTiles3--;
    }

    public void CheckFreeTile4()
    {
        global.freeTiles4--;
    }

    public void CheckFreeTile5()
    {
        global.freeTiles5--;
    }

    public void CheckFreeTile6()
    {
        global.freeTiles6--;
    }

    public void CheckFreeTile7()
    {
        global.freeTiles7--;
    }
}
