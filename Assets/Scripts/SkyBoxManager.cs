using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxManager : MonoBehaviour
{
    [SerializeField] private SkyBoxManagerScriptableObject ThisSkyBoxManagerData;

    private void Start()
    {
        InvokeRepeating("ChangeSkybox", 0f, ThisSkyBoxManagerData.TimeTillNextChange);
    }

    void ChangeSkybox()
    {
        int number = Random.Range(1, 5);
        switch (number)
        {
            case 1:
                RenderSettings.skybox = ThisSkyBoxManagerData.Skybox1;
                break;
            case 2:
                RenderSettings.skybox = ThisSkyBoxManagerData.Skybox2;
                break;
            case 3:
                RenderSettings.skybox = ThisSkyBoxManagerData.Skybox3;
                break;
            default:
                RenderSettings.skybox = ThisSkyBoxManagerData.Skybox4;
                break;
        }
    }
}
