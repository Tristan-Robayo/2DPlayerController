using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove( InputAction.CallbackContext action ) {
        if ( action.performed ) {
            rb.AddForce(action.ReadValue<Vector2>() * 100);
        }
    }

    public void OnJump(InputAction.CallbackContext action) {
        if (action.performed) {
            rb.AddForce( new Vector2( 0, 1000 ) ); ;
        }
    }
}
