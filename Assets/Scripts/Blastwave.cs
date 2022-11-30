using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blastwave : MonoBehaviour
{
    public int pointsCount;
    public float maxRadius;
    public float speed;
    public float startWidth;
    private LineRenderer lineRenderer;
    public float force;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = pointsCount + 1;
    }

    private IEnumerator Blast()
    {
        float currentRadius = 0f;

        while (currentRadius< maxRadius)
        {
            currentRadius += Time.deltaTime * speed;
            Draw(currentRadius);
            Damage(currentRadius);
            yield return null;
        }
    }

    private void Damage(float currentRadius)
    {
        Collider[] hittinObjects = Physics.OverlapSphere(transform.position, currentRadius);

        for (int i = 0; i < hittinObjects.Length; i++)
        {
            Rigidbody rb = hittinObjects[i].GetComponent<Rigidbody>();

            if (!rb)
            {
                continue;
            }

            Vector3 direction = (hittinObjects[i].transform.position - transform.position).normalized;
            rb.AddForce(direction * force, ForceMode.Impulse);
        }
    }

    private void Draw(float currentRadius)
    {
        float angleBetweenPoints = 360f / pointsCount;

        for(int i =0;i <= pointsCount; i++)
        {
            float angle = i * angleBetweenPoints * Mathf.Deg2Rad;
            Vector3 direction = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0f);
            Vector3 position = direction * currentRadius;

            lineRenderer.SetPosition(i, position);
        }

        lineRenderer.widthMultiplier = Mathf.Lerp(0f, startWidth, 1f - currentRadius / maxRadius);
    }

   


    public void blasts()
    {
        StartCoroutine(Blast());
    }
            
            
}
