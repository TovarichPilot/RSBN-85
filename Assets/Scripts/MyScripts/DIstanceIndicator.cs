using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DIstanceIndicator : MonoBehaviour
{
     public UnityEngine.UI.Text DistanceIndicator;
    static public bool DistanceCondition = false;
    static public int IterationOfDistance = 2;
    public GameObject ButtonAzimuth;

    void Update()
    {

        if (TestButton.TestButtonActivated && (!DistanceCondition || !AzimutIndicatorScript.AzimuthCondition))
        {
            DistanceIndicator.text = "" + PlaneController.DistanceBetweenAirplaneAndRSBN;
        }


        if ((DistanceCondition || AzimutIndicatorScript.AzimuthCondition) && !TestButton.TestButtonActivated)
        {
            if (FrequencyController.currentFrequency == 1000)
            {
                DistanceIndicator.text = "" + PlaneController.DistanceBetweenAirplaneAndRSBN;
            }
           
            else
            {
                DistanceIndicator.text = "000.0";
            }
        }

        //change color if azimut indicator is pressed
        if (AzimutIndicatorScript.AzimuthCondition || !(IterationOfDistance % 2 == 0))
        {
            DistanceIndicator.GetComponent<Text>().color = Color.red;
        }
        else
        {
            DistanceIndicator.GetComponent<Text>().color = Color.black;
            DistanceIndicator.text = "000.0";
        }

    }

    public void ChangeColorOnClock()
    {

        if (IterationOfDistance%2 == 0)
        {
            DistanceCondition = true;
            IterationOfDistance++;
            ButtonAzimuth.GetComponent<Button>().interactable = false;
        }
        else
        {
            DistanceCondition = false;
            IterationOfDistance++;
            ButtonAzimuth.GetComponent<Button>().interactable = true;
        }

    }
}
