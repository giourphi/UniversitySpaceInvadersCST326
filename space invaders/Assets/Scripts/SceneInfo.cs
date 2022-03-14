
using UnityEngine;
using ScriptableObject = UnityEngine.ScriptableObject;



[UnityEngine.CreateAssetMenu(fileName = "SceneInfo", menuName = "Persistence")]

public class SceneInfo : ScriptableObject
{
    public bool isNextScene = true; 
}


