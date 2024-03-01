using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        this._animator = GetComponent<Animator>();
        //this._animator.speed = this._animator.speed / 2.0f;
        this._animator.speed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
