using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;
        public float interactionDistance = 2f; // Increase the interaction range here

        private Animator animator;
        private bool isInteracting = false;
        [SerializeField] private KeybindsData keybinds;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(keybinds.Interact) && !isInteracting)
            {
                Interact();
            }
            else if (!isInteracting)
            {
                MoveCharacter();
            }
        }

        private void MoveCharacter()
        {
            Vector2 dir = Vector2.zero;
            if (Input.GetKey(keybinds.Left))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(keybinds.Right))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(keybinds.Up))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(keybinds.Down))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }

            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;
        }

        private void Interact()
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, interactionDistance);
            foreach (Collider2D collider in colliders)
            {
                NPC npc = collider.GetComponent<NPC>();
                if (npc != null)
                {
                    // Freeze the player's movement
                    isInteracting = true;

                    // Call the interaction method on the NPC
                    npc.Interact();

                    // You can add any other logic here for the interaction

                    // Unfreeze the player's movement after the interaction is complete
                    isInteracting = false;

                    break; // Exit the loop after interacting with one NPC (if multiple are within range)
                }
            }
        }
    }
}
