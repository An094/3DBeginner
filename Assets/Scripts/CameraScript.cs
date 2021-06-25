using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject thirdPersonCamera;
    public GameObject map;
    public GameObject miniMap;

    private bool isMapping;
    void SwitchCamera()
    {
        if (!isMapping)
        {
            thirdPersonCamera.SetActive(true);
            map.SetActive(false);
            miniMap.SetActive(true);
        }
        else
        {
            thirdPersonCamera.SetActive(false);
            map.SetActive(true);
            miniMap.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isMapping = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            isMapping = !isMapping;

            
        }
        SwitchCamera();

    }
}
