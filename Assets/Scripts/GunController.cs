using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private GameObject bullet;
    Plane plane = new Plane(Vector3.forward, 0);
    private Camera mainCam;

    private GameObject bulletPlaceHolder;
    // Start is called before the first frame update
    void Start()
    {
        this.bulletPlaceHolder = GameObject.Find("BulletPlaceholder");
        this.bullet = Resources.Load<GameObject>("Bullet");
        this.mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        if (Input.GetMouseButtonDown(0))
        {
            var ray = this.mainCam.ScreenPointToRay(Input.mousePosition);
            if (this.plane.Raycast(ray, out var distance))
            {
                var currentBullet = Instantiate(this.bullet);
                currentBullet.transform.position = ray.GetPoint(distance);
                var rg = currentBullet.GetComponent<Rigidbody>();
                rg.AddForce(Vector3.forward * 30);
            
                Destroy(currentBullet,1.3f);
            }
        }
        this.transform.position = mousePos;
    }
}
