using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class DontDestroy : MonoBehaviour
{

    [HideInInspector]    
    public string objectID;

    private void Awake()
    {
        objectID = name + transform.position.ToString() + transform.eulerAngles.ToString();
    }

    void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<DontDestroy>().Length; i++)
        {
            if (Object.FindObjectsOfType<DontDestroy>()[i] != this)
            {
                if (Object.FindObjectsOfType<DontDestroy>()[i].name == gameObject.name)
                {
                    Destroy(gameObject);
                }
            }
        }
        
        DontDestroyOnLoad(gameObject);
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
