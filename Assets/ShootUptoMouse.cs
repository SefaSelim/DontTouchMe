using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootUptoMouse : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    private Vector3 MousePosition;
    public Vector3 shootVector;
    
    private void OnMouseOver()
    {
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 Distance = MousePosition - this.transform.position;
        shootVector = -Distance.normalized;
        _rb.AddForce(shootVector);
    }


}
