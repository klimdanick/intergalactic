using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox : MonoBehaviour
{

    public Material skybox1, skybox2, skybox3;
    public Material[] skyboxen = new Material[3];
    public int skyboxIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        skyboxen[0] = skybox1;
        skyboxen[1] = skybox2;
        skyboxen[2] = skybox3;
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*5);
        if (RenderSettings.skybox.GetFloat("_Rotation") >= 180 * (skyboxIndex+1)) {
            skyboxIndex++;
            RenderSettings.skybox = skyboxen[skyboxIndex%3];
        } 
        //Debug.Log(RenderSettings.skybox.GetFloat("_Rotation"));
    }
}
