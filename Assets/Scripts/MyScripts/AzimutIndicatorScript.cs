using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AzimutIndicatorScript : MonoBehaviour
{
    public UnityEngine.UI.Text AzimutIndicator;
    static public bool AzimuthCondition = false;
    static public int IterationOfAzimuth = 2;
    public GameObject ButtonDistance;
    
    void Update()
    {

        if (TestButton.TestButtonActivated && AzimuthCondition)
        {
            AzimutIndicator.text = "" + PlaneController.Rotation;
        }
        else if (TestButton.TestButtonActivated && DIstanceIndicator.DistanceCondition)
        {
            AzimutIndicator.text = "" + PlaneController.AngleofRunway;
        }


        if (AzimuthCondition && !TestButton.TestButtonActivated)
        {
            if (FrequencyController.currentFrequency == 1000)
            {
                AzimutIndicator.text = "" + PlaneController.Rotation;
            }
            else
            {
                AzimutIndicator.text = "000.0";
            }
        }
        else if (DIstanceIndicator.DistanceCondition && !TestButton.TestButtonActivated)
        {

            AzimutIndicator.text = "" + PlaneController.AngleofRunway;
        }

        //change color of DistanceIndicator is pressed
        if (DIstanceIndicator.DistanceCondition || !(IterationOfAzimuth % 2 == 0))
        {
            AzimutIndicator.GetComponent<Text>().color = Color.red;
        }
        else
        {
            AzimutIndicator.GetComponent<Text>().color = Color.black;
            AzimutIndicator.text = "000.0";
        }

        
    }

    public void ChangeColorOnClock()
    {
        if (IterationOfAzimuth % 2 == 0)
        {
            AzimuthCondition = true;
            IterationOfAzimuth++;
            ButtonDistance.GetComponent<Button>().interactable = false;
        }
        else
        {
            AzimuthCondition = false;
            IterationOfAzimuth++;
            ButtonDistance.GetComponent<Button>().interactable = true;
        }        
    }
}
