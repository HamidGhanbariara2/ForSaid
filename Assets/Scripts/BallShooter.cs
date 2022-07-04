using System.Collections;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    private const float InterpolationPeriod = 3.0f;
    private float time = 0;

    void Update()
    {
        this.time += Time.deltaTime;
        if ( this.time >=  InterpolationPeriod)
        {
            this.StartCoroutine(this.ShootBall());
            this.time = 0;
        }   
    }
    
    private IEnumerator ShootBall()
    {
        for (int i = 0; i < 5; i++)
        {
            var randX = Random.Range(-70, -30);
            var randY = Random.Range(75, 100);
            this.transform.rotation = Quaternion.Euler(randX, randY, 0);
            var target = Resources.Load<GameObject>("Target");

            var obj = Instantiate(target, this.transform);

            var rigidBody = obj.GetComponent<Rigidbody>();
            rigidBody.AddForce( this.transform.up * 100);

            yield return new WaitForSeconds(0.2f);
        }        
    }
}
