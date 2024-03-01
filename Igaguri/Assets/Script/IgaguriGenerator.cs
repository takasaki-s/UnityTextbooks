using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ?C?K?O??????
public class IgaguriGenerator : MonoBehaviour
{
    //[SerializeField] private GameObject igaguriPrefab = null;
    public GameObject igaguriPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // ?C?K?O??????
            GameObject igaguri = Instantiate(igaguriPrefab) as GameObject;

            // ?^?b?v???????u??????????????
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
