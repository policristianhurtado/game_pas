using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{

    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Vector2 direccion;
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float horizontal;
    private float vertical;
    
    void Start()
    {
        Rigidbody2D = transform.GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");


        // Debug.Log(horizontal);
        
        if (horizontal < 0.0f)
        {
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            Animator.SetBool("Left", true);
            Animator.SetBool("Right", false);
            Animator.SetBool("Down", false);
            Animator.SetBool("Up", false);
        }
        else if (horizontal > 0.0f)
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            Animator.SetBool("Left", false);
            Animator.SetBool("Right", true);
            Animator.SetBool("Down", false);
            Animator.SetBool("Up", false);
        }

        if (vertical < 0.0f)
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            Animator.SetBool("Left", false);
            Animator.SetBool("Right", false);
            Animator.SetBool("Down", vertical != 0.0f);
            Animator.SetBool("Up", false);
        }
        else if (vertical > 0.0f)
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            Animator.SetBool("Left", false);
            Animator.SetBool("Right", false);
            Animator.SetBool("Down", false);
            Animator.SetBool("Up", vertical != 0.0f);
        }
        
        // direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        
        
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(horizontal * velocidadMovimiento, vertical * velocidadMovimiento);
    }
}
