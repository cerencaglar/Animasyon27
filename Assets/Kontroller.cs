using UnityEngine;
using UnityEngine.InputSystem;

public class Kontroller : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            animator.SetTrigger("isJumped");
        }

        if(Keyboard.current.leftCtrlKey.isPressed)
        {
            animator.SetBool("isDancing", true);
        }
        else
        {
            animator.SetBool("isDancing", false);
        }

        float blendDegeri = 0f;
        if(Keyboard.current.wKey.isPressed)
        {
            animator.SetBool("isWalking", true);
            if(Keyboard.current.leftShiftKey.isPressed)
            {
                blendDegeri = 1f;

            }  
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
        //animator.SetFloat("Blend", blendDegeri);
        animator.SetFloat("Blend", blendDegeri, 0.15f, Time.deltaTime);
    }
}
