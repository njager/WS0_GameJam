using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [Header("Frame 1")]
    public GameObject frame1Log1;
    public GameObject frame1Log2;
    public GameObject frame1Log3;

    [Header("Frame 2")]
    public GameObject frame2Log1;
    public GameObject frame2Log2;
    public GameObject frame2Log3;

    [Header("Frame 3")]
    public GameObject frame3Log1;
    public GameObject frame3Log2;
    public GameObject frame3Log3;

    [Header("Frame 4")]
    public GameObject frame4Log1;
    public GameObject frame4Log2;
    public GameObject frame4Log3;

    [Header("Frame 5")]
    public GameObject frame5Log1;
    public GameObject frame5Log2;
    public GameObject frame5Log3;

    [Header("Frame 6")]
    public GameObject frame6Log1;
    public GameObject frame6Log2;
    public GameObject frame6Log3;

    [Header("Frame 7")]
    public GameObject frame7Log1;
    public GameObject frame7Log2;
    public GameObject frame7Log3;

    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance; 
    }

    void Update()
    {
        DialogueFrameCheck1();
        DialogueFrameCheck2();
        DialogueFrameCheck3();
        DialogueFrameCheck4();
        DialogueFrameCheck5();
        DialogueFrameCheck6();
        DialogueFrameCheck7();
    }

    public void DialogueFrameCheck1()
    {
        if (global.freeTiles1 == 3)
        {
            frame1Log1.SetActive(true);
            frame1Log2.SetActive(false);
            frame1Log3.SetActive(false);
        }

        if (global.freeTiles1 == 0)
        {
            frame1Log1.SetActive(false);
            frame1Log2.SetActive(true);
            frame1Log3.SetActive(false);
        }

        if (global.freeTiles1 < 0)
        {
            frame1Log1.SetActive(false);
            frame1Log2.SetActive(false);
            frame1Log3.SetActive(true);
        }

    }

    public void DialogueFrameCheck2()
    {
        if (global.freeTiles2 == 3)
        {
            frame2Log1.SetActive(true);
            frame2Log2.SetActive(false);
            frame2Log3.SetActive(false);
        }

        if (global.freeTiles2 == 0)
        {
            frame2Log1.SetActive(false);
            frame2Log2.SetActive(true);
            frame2Log3.SetActive(false);
        }

        if (global.freeTiles2 < 0)
        {
            frame2Log1.SetActive(false);
            frame2Log2.SetActive(false);
            frame2Log3.SetActive(true);
        }
    }

    public void DialogueFrameCheck3()
    {
        if (global.freeTiles3 == 3)
        {
            frame3Log1.SetActive(true);
            frame3Log2.SetActive(false);
            frame3Log3.SetActive(false);
        }

        if (global.freeTiles3 == 0)
        {
            frame3Log1.SetActive(false);
            frame3Log2.SetActive(true);
            frame3Log3.SetActive(false);
        }

        if (global.freeTiles3 < 0)
        {
            frame1Log3.SetActive(false);
            frame1Log3.SetActive(false);
            frame1Log3.SetActive(true);
        }
    }

    public void DialogueFrameCheck4()
    {
        if (global.freeTiles4 == 3)
        {
            frame4Log1.SetActive(true);
            frame4Log2.SetActive(false);
            frame4Log3.SetActive(false);
        }

        if (global.freeTiles4 == 0)
        {
            frame4Log1.SetActive(false);
            frame4Log2.SetActive(true);
            frame4Log3.SetActive(false);
        }

        if (global.freeTiles4 < 0)
        {
            frame4Log1.SetActive(false);
            frame4Log2.SetActive(false);
            frame4Log3.SetActive(true);
        }
    }

    public void DialogueFrameCheck5()
    {
        if (global.freeTiles5 == 3)
        {
            frame5Log1.SetActive(true);
            frame5Log2.SetActive(false);
            frame5Log3.SetActive(false);
        }

        if (global.freeTiles5 == 0)
        {
            frame5Log1.SetActive(false);
            frame5Log2.SetActive(true);
            frame5Log3.SetActive(false);
        }

        if (global.freeTiles5 < 0)
        {
            frame5Log1.SetActive(false);
            frame5Log2.SetActive(false);
            frame5Log3.SetActive(true);
        }
    }

    public void DialogueFrameCheck6()
    {
        if (global.freeTiles6 == 3)
        {
            frame6Log1.SetActive(true);
            frame6Log2.SetActive(false);
            frame6Log3.SetActive(false);
        }

        if (global.freeTiles6 == 0)
        {
            frame6Log1.SetActive(false);
            frame6Log2.SetActive(true);
            frame6Log3.SetActive(false);
        }

        if (global.freeTiles6 < 0)
        {
            frame6Log1.SetActive(false);
            frame6Log2.SetActive(false);
            frame6Log3.SetActive(true);
        }
    }

    public void DialogueFrameCheck7()
    {
        if (global.freeTiles7 == 3)
        {
            frame7Log1.SetActive(true);
            frame7Log2.SetActive(false);
            frame7Log3.SetActive(false);
        }

        if (global.freeTiles7 == 0)
        {
            frame7Log1.SetActive(false);
            frame7Log2.SetActive(true);
            frame7Log3.SetActive(false);
        }

        if (global.freeTiles7 < 0)
        {
            frame7Log1.SetActive(false);
            frame7Log2.SetActive(false);
            frame7Log3.SetActive(true);
        }
    }
}
