using UnityEngine;

public class player_controller : MonoBehaviour
{

    Animator animController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animController = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        float vertical;
        float horizontal;
        animController.speed = 1.0f;
        

        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        if (vertical > 0) // Player pressed up.
        {
            animController.SetInteger("direction", 1);
        }
        if (vertical <= 0) // Player pressed down or no vertical input
        {
            animController.SetInteger("direction", 2);
        }
        if (horizontal > 0)
        {
            animController.SetInteger("direction", 4); // Left
        }
        if (horizontal < 0)
        {
            animController.SetInteger("direction", 3); // Right
        }
        if ((horizontal == 0f) && (vertical == 0f))
        {
            animController.speed = 0f;
        }
    }
}
