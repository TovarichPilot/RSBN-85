using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
     static public float DistanceBetweenAirplaneAndRSBN;
    static public float Rotation;
    public float speed, CameraXPosition, CameraYPosition, CameraZPosition, tilt, AirplaneX, AirplaneY, AirplaneZ, DistanceBetweenAirplaneAndKRM, ShortDistanceBetweenAirplaneAndKRM;
    static public float AngleofRunway;
    Rigidbody AirPlane;
   
   
    void Start()
    {
        AirPlane = GetComponent<Rigidbody>();   
    }

    
    void Update()
    {
        Vector3 moveCamTo = transform.position - transform.forward * CameraXPosition + Vector3.up * CameraYPosition - 1.5f* transform.right * CameraZPosition;
        float bias = 0.96f;
        Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo * (1.0f - bias);

        Camera.main.transform.LookAt(transform.position + transform.forward * 30.0f);

        transform.position += transform.forward * Time.deltaTime * speed;


        speed -= transform.forward.y * Time.deltaTime * 20.0f;
        if (speed < 10.0f)
        {
            speed = 10.0f;
        }

        if (speed > 40.0f)
        {
            speed = 40.0f;
        }

        transform.Rotate(Input.GetAxis("Vertical") * tilt, 0.0f, -Input.GetAxis("Horizontal") * tilt * 2.0f);

        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

        if (terrainHeightWhereWeAre > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, terrainHeightWhereWeAre, transform.position.z);
        }
        AirplaneX = transform.position.x;
        AirplaneY = transform.position.y;
        AirplaneZ = transform.position.z;
        
        DistanceBetweenAirplaneAndRSBN = Mathf.Pow((Mathf.Pow((AirplaneX - 2271.0f), 2) + Mathf.Pow(AirplaneY, 2) + Mathf.Pow((AirplaneZ - 542.5f), 2)), 0.5f) / 100;
        DistanceBetweenAirplaneAndRSBN = (float)System.Math.Round((double)DistanceBetweenAirplaneAndRSBN, 1);


        if (transform.localEulerAngles.y >= 0)
        {
            Rotation = transform.localEulerAngles.y;
        }
        else
        {
            Rotation = - transform.localEulerAngles.y;
        }
        
        Rotation = (float)System.Math.Round((double)Rotation, 1);


        DistanceBetweenAirplaneAndKRM = Mathf.Pow((Mathf.Pow((AirplaneX - 2437.0f), 2) + Mathf.Pow((AirplaneZ - 512.5f), 2)), 0.5f);
        if (AirplaneX >= 2437.0f)
        {
            ShortDistanceBetweenAirplaneAndKRM = AirplaneX - 2437.0f;
        }
        else
        {
            ShortDistanceBetweenAirplaneAndKRM =  2437.0f - AirplaneX;
        }



        AngleofRunway = Mathf.Acos(ShortDistanceBetweenAirplaneAndKRM / DistanceBetweenAirplaneAndKRM) * 180 / 3.1415f;
        AngleofRunway = (float)System.Math.Round((double)AngleofRunway, 1);
    }
}
