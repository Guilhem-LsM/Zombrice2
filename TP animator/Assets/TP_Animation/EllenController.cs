using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllenController : MonoBehaviour
{
    public Transform body;
    public Animator animator;
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetFloat("Velocity", Mathf.Min(animator.GetFloat("Velocity") + 0.01f, 1f)); Console.Write("efefef");
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            animator.SetFloat("Velocity", Mathf.Max(animator.GetFloat("Velocity") - 0.01f, -1f));
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            animator.SetFloat("Direction", Mathf.Min(animator.GetFloat("Direction") + 0.01f, 1f));
        else if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
            animator.SetFloat("Direction", Mathf.Max(animator.GetFloat("Direction") - 0.01f, -1f));
    }
}
