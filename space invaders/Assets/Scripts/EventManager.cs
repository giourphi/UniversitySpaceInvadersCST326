using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;
    public EventManager eventManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        if (eventManager != null)
        {
            Destroy(eventManager);
            eventManager = this;

        }
        else
        {
            eventManager = this;
        }


    }
}
