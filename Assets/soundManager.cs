using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager instance;
    public AudioSource coinssource;
    public AudioClip coinSound;
  

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinssource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
