using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBorderColliderController : MonoBehaviour
{
    [SerializeField] private string NameOfPart;
    public bool boolean = true;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("DeathBorder") && boolean)
        {
            SceneManager.LoadScene(NameOfPart);
        }
    }
}
