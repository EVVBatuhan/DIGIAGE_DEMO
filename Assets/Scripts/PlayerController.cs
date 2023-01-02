using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _anim;
    [SerializeField] GameObject player;
    public float speed;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        _anim = player.GetComponent<Animator>();
        _anim.SetBool("run", true);
    }


    void Update()
    {
        Movement();
    }
    void Movement()
    {
        CharacterController controller = GetComponent<CharacterController>();
        moveDirection = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        controller.Move(moveDirection * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("gate"))
        {
            var gateManager = other.GetComponent<GateManager_1>();


            Debug.Log("Collided");

            if (gateManager.multiply)
            {
                player.transform.localScale *= gateManager.randomNumber;
            }
            else
            {
                player.transform.localScale /= gateManager.randomNumber;
            }
        }
    }
}
