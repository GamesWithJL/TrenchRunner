using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalGenerator : MonoBehaviour
{

    public ObjectPooler medalPool;

    public float distanceBetweenMedals;
   
    public void SpawnMedals(Vector3 startPosition)
    {
        GameObject medal1 = medalPool.GetPooledObject();
        medal1.transform.position = startPosition;
        medal1.SetActive(true);

        GameObject medal2 = medalPool.GetPooledObject();
        medal2.transform.position = new Vector3(startPosition.x - distanceBetweenMedals, startPosition.y, startPosition.z);
        medal2.SetActive(true);

        GameObject medal3 = medalPool.GetPooledObject();
        medal3.transform.position = new Vector3(startPosition.x + distanceBetweenMedals, startPosition.y, startPosition.z);
        medal3.SetActive(true);
    }
}
