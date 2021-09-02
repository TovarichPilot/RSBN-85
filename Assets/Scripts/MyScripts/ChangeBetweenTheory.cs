using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBetweenTheory : MonoBehaviour
{
    public GameObject[] MyPictures;

    public void OpenPicture()
    {
        for (int i = 0; i < MyPictures.Length; i++)
        {
            if (i==0)
            {
                MyPictures[i].SetActive(true);
            }
            else
            {
                MyPictures[i].SetActive(false);
            }
           
        }
    }

    public void OpenDefinition()
    {
        for (int i = 0; i < MyPictures.Length; i++)
        {
            if (i == 1)
            {
                MyPictures[i].SetActive(true);
            }
            else
            {
                MyPictures[i].SetActive(false);
            }
        }
    }

    public void OpenAdditionalInformation()
    {
        for (int i = 0; i < MyPictures.Length; i++)
        {
            if (i == 2)
            {
                MyPictures[i].SetActive(true);
            }
            else
            {
                MyPictures[i].SetActive(false);
            }
        }
    }
    public void OpenTypesOfWorks()
    {
        for (int i = 0; i < MyPictures.Length; i++)
        {
            if (i == 3)
            {
                MyPictures[i].SetActive(true);
            }
            else
            {
                MyPictures[i].SetActive(false);
            }
        }
    }

    public void OpenAdditionalTypesOfWork()
    {
        for (int i = 0; i < MyPictures.Length; i++)
        {
            if (i == 4)
            {
                MyPictures[i].SetActive(true);
            }
            else
            {
                MyPictures[i].SetActive(false);
            }
        }
    }

    public void OpenFeatures()
    {
        for (int i = 0; i < MyPictures.Length; i++)
        {
            if (i == 5)
            {
                MyPictures[i].SetActive(true);
            }
            else
            {
                MyPictures[i].SetActive(false);
            }
        }
    }

    public void OpenTechnicaInformation()
    {
        for (int i = 0; i < MyPictures.Length; i++)
        {
            if (i == 6)
            {
                MyPictures[i].SetActive(true);
            }
            else
            {
                MyPictures[i].SetActive(false);
            }
        }
    }
}
