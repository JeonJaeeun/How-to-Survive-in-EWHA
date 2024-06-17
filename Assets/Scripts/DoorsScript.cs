using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsScript : MonoBehaviour {

    bool IsOpen = false;
    private Animator _animator;
	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}

    private void OnCollisionEnter(Collision other) {
        if ((other.gameObject.CompareTag("Player")) && (IsOpen == false))
        {
            Debug.Log("Player entered the door trigger");
            _animator.SetBool("open", true);
            IsOpen = true;
        }
    }

    private void OnCollisionExit(Collision other) {
        if ((other.gameObject.CompareTag("Player")) && (IsOpen == true))
        {
            Debug.Log("Player exited the door trigger");
            _animator.SetBool("open", false);
            IsOpen = false;
        }
    }

}
