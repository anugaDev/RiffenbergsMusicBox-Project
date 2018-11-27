﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventObject : InteractableObject {

    [SerializeField] private UnityEvent m_event;

    [SerializeField] private Outline m_objectOutline;
    
    






    // Use this for initialization
    void Start()
    {
        GameManager.m_instance.m_interactableObjects.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        m_objectOutline.enabled = false;
    }
    public override void OnClick()
    {
        if (!GameManager.m_instance.m_playerNav.m_BoxOn)
        {

            m_event.Invoke();
            
            m_objectOutline.enabled = false;
            
           

        }
    }
    public override void MouseOver()
    {
        if (!GameManager.m_instance.m_playerNav.m_BoxOn)
        {
            m_objectOutline.enabled = true;
        }

    }
    public override Transform ReturnObject()
    {
        return this.transform;
    }
   
}
