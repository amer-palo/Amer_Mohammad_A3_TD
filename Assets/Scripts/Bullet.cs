using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;
    public float explosion = 0f;

    public void Seek (Transform _target)
    {
        target = _target;
    }
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisframe = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisframe)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisframe, Space.World);
        transform.LookAt(target);
    }

    void HitTarget()
    {

        
        Destroy(gameObject);

        if (explosion > 0f)
        {
            Explode();
        }
        else
        {
            Damage(target);
        }
        Debug.Log("destroyed");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            HitTarget();
        }
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosion);
        foreach (Collider colldier in colliders)
        {
            if (colldier.tag == "Enemy")
            {
                Damage(colldier.transform);
            }
        }
    }

    void Damage (Transform enemy)
    {
        Destroy(enemy.gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosion);
    }
}
