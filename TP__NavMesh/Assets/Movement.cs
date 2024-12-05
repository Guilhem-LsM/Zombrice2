using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

namespace TP__NavMesh

{
    public class PlayerController : MonoBehaviour
    {

        public CharacterController controller;

        private InputPlayer inputActions;
        private Vector2 moveInput;

        public float speed = 5f;
        public float gravity = -10f;
        public float jumpForce = 3f;

        public float hp;

        Vector3 velocity;

        private void Awake()
        {
            inputActions = new InputPlayer();
            inputActions.Gameplay.Enable();
        }


        void Update()
        {

            moveInput = inputActions.Gameplay.Move.ReadValue<Vector2>();
            Vector3 move = transform.right * moveInput.x + transform.forward * moveInput.y;
            controller.Move(move * speed * Time.deltaTime);
            velocity.y += gravity * 0.8f * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }

    }
}