using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    private Controls MoveCube;
    public Controls.MoveCubeActions playerInputOnMOveCube;
    public GameObject bulletToShot;
    public Camera cam;
    public GameObject positionToRespawn;
    public float forceToShoot;

    private float shotRate = 0.5f;
    private float shootRateTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        MoveCube = new Controls();
        playerInputOnMOveCube = MoveCube.MoveCube;
        MoveCube.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > shootRateTime)
        {
            if (playerInputOnMOveCube.Shoot.triggered)
            {
                GameObject currentBullet = Instantiate(bulletToShot, positionToRespawn.transform.position, cam.transform.rotation);
                currentBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * forceToShoot, ForceMode.VelocityChange);
                shootRateTime = Time.time + shotRate;
                Destroy(currentBullet, 5f);

            }
        }

        //if (playerInputOnMOveCube.Shoot.triggered)
        //{
        //    GameObject currentBullet = Instantiate(bulletToShot, positionToRespawn.transform.position, cam.transform.rotation);
        //    currentBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * forceToShoot, ForceMode.VelocityChange);
        //    Destroy(currentBullet, 5f);

        //}
    }
}
