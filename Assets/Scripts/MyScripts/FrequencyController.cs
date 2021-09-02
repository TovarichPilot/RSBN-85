using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrequencyController : MonoBehaviour
{
    public UnityEngine.UI.Text Frequency;
    public static float currentFrequency = 1000.0f;
    public float AdditionalFrequency = 1000.0f;
    public float DeltaFrequency = 1f;
    public float MinFrequency = 939.6f, MaxFrequency = 1000.5f;
 
   

    void Update()
    {
 
        if (TestButton.Iteration%2 == 1 && !(TestButton.Iteration%2 == 1))
        {
                currentFrequency = AdditionalFrequency;
        }
        Frequency.text = "" + currentFrequency;
        currentFrequency = Mathf.Clamp(currentFrequency, MinFrequency, MaxFrequency);
        AdditionalFrequency = currentFrequency;
    }

    public void IncreaseCurrentFrequency()
    {

        if (!TestButton.TestButtonActivated)
        {
            currentFrequency += 0.1f * DeltaFrequency;
            currentFrequency = (float)System.Math.Round((double)currentFrequency, 1);
        }
    }

    public void DecreaseCurrentFrequency()
    {

        if (!TestButton.TestButtonActivated)
        {
            currentFrequency -= 0.1f * DeltaFrequency;
            currentFrequency = (float)System.Math.Round((double)currentFrequency, 1);
        }
    }

    public void DeltaFrequencyOne()
    {
        DeltaFrequency = 1;
    }
    public void DeltaFrequencyTen()
    {
        DeltaFrequency = 10;  
    }
    public void DeltaFrequencyOneHundred()
    {
        DeltaFrequency = 100;
    }
}
