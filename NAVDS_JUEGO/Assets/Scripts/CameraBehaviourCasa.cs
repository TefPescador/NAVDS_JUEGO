using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviourCasa : MonoBehaviour
{
    public Vector3 CamOffSet = new Vector3(0f, -2f, 0f);

    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.Find("Prota").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        this.transform.position = _target.TransformPoint(CamOffSet);
        this.transform.LookAt(_target);
    }
}
