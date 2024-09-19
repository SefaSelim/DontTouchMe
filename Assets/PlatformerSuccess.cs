using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerSuccess : MonoBehaviour
{
    [SerializeField]private DeathBorderColliderController _deathBorderColliderController;
    [SerializeField] private Animator _animator;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _animator.SetBool("IsJumped",true);
            _deathBorderColliderController.boolean = false;
        }
    }
}
