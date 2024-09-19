using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VelocityScanner : MonoBehaviour
{
    [SerializeField] private TMP_Text MaxSpeedText;
    [SerializeField] private TMP_Text WhatShouldYouDoText;

    [SerializeField] private Animator _animator;
    
    private float Speed;
    private float MaxSpeed = 0;
    public float Target;
    
    private Vector3 firstPosition,lastPosition;
    private bool forOnce = true;
    void Start()
    {
        firstPosition = this.transform.position;
        lastPosition = firstPosition;
        WhatShouldYouDoText.text = "GET OVER "+ Target +" SPEED";
    }

    // Update is called once per frame
    void Update()
    {
        if (forOnce)
        {
            lastPosition = this.transform.position;
            forOnce = false;
        }
        else
        {
            firstPosition = lastPosition;
            lastPosition = this.transform.position;
        }
        
        //CALCULATIONS

        Vector3 SpeedVector = lastPosition - firstPosition;

        Speed = (Mathf.Sqrt(Mathf.Pow(SpeedVector.x, 2) + Mathf.Pow(SpeedVector.y, 2)))/Time.deltaTime;

        if (Speed > MaxSpeed)
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
        WhatShouldYouDoText.text = "";
        WhatShouldYouDoText.color = Color.black;
        _animator.SetBool("IsJumped",true);
    }

    void UpdateText()
    {
        MaxSpeedText.text = MaxSpeed.ToString();
    }
    
    
    
}
