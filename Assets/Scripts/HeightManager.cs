using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class HeightManager : MonoBehaviour
{
    
    private CharacterController _characterController;
    private SphereCollider _sphereCollider;
    private XROrigin _xrOrigin;
    [SerializeField] private float desiredHeight;
    [SerializeField] private Transform cameraTransform;

    
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _sphereCollider = GetComponent<SphereCollider>();
        _xrOrigin = GetComponent<XROrigin>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _characterController.height = desiredHeight;
        _characterController.center.Set(0, desiredHeight / 2f, 0);
        cameraTransform.transform.localPosition = new Vector3(0, desiredHeight, 0);
        _sphereCollider.center.Set(0, desiredHeight, 0);
        _xrOrigin.CameraYOffset = desiredHeight;
    }
}
