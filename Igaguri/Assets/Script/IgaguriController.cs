using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ?C?K?O??????
public class IgaguriController : MonoBehaviour
{
    private bool _destroyFlag = false;
    private uint _destroyCount = 0;

    // ?C?K?O??????????
    public void Shoot(Vector3 dir)
    {
        _destroyCount = 30 * 5;
        GetComponent<Rigidbody>().AddForce(dir);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {
        if(_destroyFlag == true)
        {
            /*
            if (_destroyCount?)
            {

            }
            */
        }
    }

    // ?C?K?O?????I???h??
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        _destroyFlag = true;
    }
}
