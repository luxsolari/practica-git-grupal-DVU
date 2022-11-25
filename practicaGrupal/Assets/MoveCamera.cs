using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    private Controls MoveCube;
    public Controls.MoveCubeActions playerInputOnMOveCube;
    private CameraLookCotrol lookControl;
    // Start is called before the first frame update
    void Start()
    {
        lookControl = gameObject.GetComponent<CameraLookCotrol>();
        MoveCube = new Controls();
        playerInputOnMOveCube = MoveCube.MoveCube;
        MoveCube.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        lookControl.LoockProcess(playerInputOnMOveCube.CameraController.ReadValue<Vector2>());
    }
}
