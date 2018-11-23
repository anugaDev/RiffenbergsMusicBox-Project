﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitInteractable : MonoBehaviour, InteractableObject {

    [SerializeField] Transform m_exitCanvas;

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
    public void OnClick()
    {
        if (!GameManager.m_instance.m_playerNav.m_BoxOn)
        {
            
            m_exitCanvas.gameObject.SetActive(true);
            
            m_objectOutline.enabled = false;
            
           

        }
    }
    public void MouseOver()
    {
        if (!GameManager.m_instance.m_playerNav.m_BoxOn)
        {
            m_objectOutline.enabled = true;
        }

    }
    public Transform ReturnObject()
    {
        return this.transform;
    }
   
}
