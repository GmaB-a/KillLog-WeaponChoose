using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SkyBoxManager", menuName = "SkyBox Manager Data", order = 52)]
public class SkyBoxManagerScriptableObject : ScriptableObject
{
    public float TimeTillNextChange;
    public Material Skybox1;
    public Material Skybox2;
    public Material Skybox3;
    public Material Skybox4;
}
