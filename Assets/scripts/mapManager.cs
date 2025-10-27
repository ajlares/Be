using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class mapManager : MonoBehaviour
{
    public float yMax;
    public float xMax;
    public float moveSpeed;
    public float spawnTime = 1;
    public GameObject prefab;
    
    public static mapManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        moveSpeed *= -1;
        InvokeRepeating("CreateMap",0f, spawnTime);
    }

    private void CreateMap()
    {
        Vector3 spawnVector3 = new Vector3(Random.Range(-xMax,xMax),yMax,0);
       GameObject obj = Instantiate(prefab, spawnVector3, transform.rotation);
       obj.transform.parent = this.transform;
       obj.name = "Cubito";
    }

    public void FlipMap()
    {
        yMax *= -1;
        moveSpeed *= -1;
        this.gameObject.transform.Rotate(0, 0,180);
    }
}
