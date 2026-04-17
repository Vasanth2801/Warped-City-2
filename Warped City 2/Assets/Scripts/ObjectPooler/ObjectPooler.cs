using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class ObjectPoolItem
    {
        public string objectTag;
        public GameObject prefab;
        public int size;
    }

    public ObjectPoolItem[] pools;
    public Dictionary<string, Queue<GameObject>> poolsOfDictionary;

    private void Start()
    {
        poolsOfDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach(ObjectPoolItem pool in pools)
        {
            Queue<GameObject> obj = new Queue<GameObject>();

            for(int i = 0;i< pool.size; i++)
            {
                GameObject 
            }
        }
    }
}