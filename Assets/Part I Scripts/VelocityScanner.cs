using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VelocityScanner : MonoBehaviour
{
    public bool shouldSkipTexts;
    [SerializeField] private TMP_Text MaxSpeedText;
    [SerializeField] private TMP_Text WhatShouldYouDoText;
    [SerializeField] private Rigidbody2D _rb;

    [SerializeField] private Animator _animator;
    
    private float Speed;
    private float MaxSpeed = 0;
    public float Target;
    

    // Update is called once per frame
    void Update()
    {
        
        //CALCULATIONS
        Speed = _rb.velocity.magnitude;

       
        {
            MaxSpeed = (int)Speed;
            UpdateText();
        }
        
        
        
        

        if (Speed >= Target)
        {
            Won();
        }



    }

    void Won()
    {
        if (!shouldSkipTexts)
        {
            WhatShouldYouDoText.text = "";
            WhatShouldYouDoText.color = Color.black;
        }
        _animator.SetBool("IsJumped",true);
    }

    void UpdateText()
    {
        if (!shouldSkipTexts)
        {
            MaxSpeedText.text = MaxSpeed.ToString();
        }
    }
    
    
    
}
