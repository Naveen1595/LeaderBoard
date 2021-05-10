using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : MonoBehaviour
{
    public List<GameObject> polledObject;
    public GameObject objectToPool;
    public static Object sharedInstance;
    [SerializeField] private int amtToPool;

    private void Awake()
    {
        sharedInstance = this;
    }

    private void Start()
    {
        polledObject = new List<GameObject>();
        GameObject temp;
        for(int i=0;i<amtToPool;i++)
        {
            temp = Instantiate(objectToPool);
            temp.SetActive(false);
            polledObject.Add(temp);
        }
    }

    public GameObject GetPooledObject()
    {
        for(int i=0;i<amtToPool;i++)
        {
            if(!polledObject[i].activeInHierarchy)
            {
                polledObject[i].SetActive(true);
                return polledObject[i];
            }
        }
        return null;
    }

}
