using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestButton : MonoBehaviour
{
    static public bool  TestButtonActivated = false;
    static public int Iteration = 3;
    public GameObject[] ButtonsController;

    public void ChangeValues()
    {
        if (Iteration%2 == 1)
        {
            TestButtonActivated = true;
            Iteration++;


            for (int i = 0; i < ButtonsController.Length; i++)
            {
                ButtonsController[i].GetComponent<Button>().interactable = false;

            }
        }
        else
        {
            TestButtonActivated = false;
            Iteration++;

            for (int i = 0; i < ButtonsController.Length; i++)
            {

                if (((i == 9) && (AzimutIndicatorScript.IterationOfAzimuth % 2 == 1)))
                {
                    ButtonsController[9].GetComponent<Button>().interactable = false;
                }
                else if (((i == 8) && (DIstanceIndicator.IterationOfDistance % 2 == 1)))
                {
                    ButtonsController[8].GetComponent<Button>().interactable = false;
                }
                else
                {
                    ButtonsController[i].GetComponent<Button>().interactable = true;
                }
                
            }
        }
       
    }
}
