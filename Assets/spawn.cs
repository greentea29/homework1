using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject enemy;
    int noode = 1;
    // Start is called before the first frame update
    void Start()
    {
        spawnenemy(noode);
    }
    void spawnenemy(int n)
    {
        for(int i = 0;i < n; i++)
        {
            Instantiate(enemy, randompos(), enemy.transform.rotation);
        }
        
    }
    Vector3 randompos()
    {
        float xpos = Random.Range(-10, 10);
        float zpos = Random.Range(-10, 10);
        Vector3 ret = new Vector3(xpos, 0, zpos);
        return ret;
    }

    public int enemycount;
    void Update()
    {
        enemycount = FindObjectsOfType<enemy>().Length;
        if(enemycount == 0)
        {
            noode++;
            spawnenemy(noode);
        }
    }
}
