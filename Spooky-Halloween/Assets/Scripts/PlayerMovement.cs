using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    //variable del animator
    private Animator anim;

    //variable del charactercontroller
    private CharacterController controller;

    //variable de velocidad
    public float speed = 6.0f;

    //variable de gravedad
    public float gravity = 20.0f;

    //Variable de dirección
	private Vector3 moveDirection = Vector3.zero;

	//Variable que hace referencia a la velocidad
	private float w_sp = 0.0f;

	//Variable que hace referencia a la velocidad de movimientos
	private float r_sp = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<charactercontroller>();
        w_sp = speed; //read walk speed
        runSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        CheckAnimation();
    }

    public void CheckAnimation()
    {
        //------------------------------------------------------------------ MOV

        if(Input.GetKey("w"))
        {
            anim.setInteger("moving", 1);
            runSpeed = 1;
        }
        else 
        {
            anim.setInteger("moving", 0);
        }

        if(Input.GetKey("s"))
        {
            anim.setInteger("moving", 12);
        }

        //--------------------------------------------------------------------ATTACK

        if (Input.GetMouseButtonDown(0))
		{ // attack1
			anim.SetInteger("attack", 1);
		}
		else
        {
			anim.SetInteger("attack", 0);
        }
    }
}
