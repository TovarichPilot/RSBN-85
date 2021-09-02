using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorDuringTest : MonoBehaviour
{
    public UnityEngine.UI.Text Indicator;

    
    void Update()
    {
        if (TestButton.TestButtonActivated)
        {
            

            Indicator.GetComponent<Text>().color = Color.red;
   
            StartCoroutine(c_Blinking(GetComponent<Text>()));
        }
        else 
        {
            Indicator.GetComponent<Text>().color = Color.white;

        }
        
    }

    IEnumerator c_Blinking(Text text)
    {
        Color c = text.color;

        float alpha = 1.0f;

        while (TestButton.TestButtonActivated)
        {
            c.a = Mathf.MoveTowards(c.a, alpha, Time.deltaTime);

            text.color = c;

            if (c.a == alpha)
            {
                if (alpha == 1.0f)
                {
                    alpha = 0.0f;
                }
                else
                    alpha = 1.0f;
            }

            yield return null;
        }
    }
}
