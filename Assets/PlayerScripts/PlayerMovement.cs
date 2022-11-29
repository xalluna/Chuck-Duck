using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    public Sound WalkingSound;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Animator>();
        WalkingSound.Source = gameObject.AddComponent<AudioSource>();
        WalkingSound.Source.clip = WalkingSound.Clip;
        WalkingSound.Source.volume = WalkingSound.Volume;
        WalkingSound.Source.pitch = WalkingSound.Pitch;
        WalkingSound.Source.loop = WalkingSound.Loop;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if(move.Equals(Vector3.zero)){ WalkingSound.Source.Play();} 
    }
}
