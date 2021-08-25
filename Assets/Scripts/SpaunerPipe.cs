using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpaunerPipe : MonoBehaviour
{
    [SerializeField]
    public float speed = 1f;
    public static float speedForScript = 1f;

    private readonly List<Renderer> _creater = new List<Renderer>();
    private readonly List<Renderer> _visibled = new List<Renderer>();
    private readonly List<GameObject> _free = new List<GameObject>();
    [SerializeField]
    private GameObject pipe;
    private GameObject inst_obj;
    public Vector3 startSpaun = new Vector3(5, 0, 0);
    public Vector3 nextPipe = new Vector3(3.5f, 0, 0);
    public void SpawnPipeYes()
    {
        inst_obj = GetFreeOrCreatePipe();
        inst_obj.transform.position = new Vector3(startSpaun.x, UnityEngine.Random.Range(-2.85f, 2.85f), 0);
        inst_obj.transform.rotation = Quaternion.identity;
        _creater.Add(inst_obj.GetComponent<Renderer>());

    }

    public GameObject GetFreeOrCreatePipe()
    {
        if (_free.Count > 0)
        {
            var temp = _free[0];
            _free.RemoveAt(0);
            return temp;
        }
        return Instantiate(pipe);
    }

    private void Start()
    {
        
        SpawnPipeYes();
    }

    private void Update()
    {
        speedForScript = speed;
        if (inst_obj.transform.position.x <= nextPipe.x)
        {
            SpawnPipeYes();
        }
        _creater.Where(x => x.isVisible).ToList().ForEach(y =>
        {
            _visibled.Add(y);
            _creater.Remove(y);
        });
        //foreach(var temp in _creater.ToList())
        //{
        //    if (temp.isVisible)
        //    {
        //        _visibled.Add(temp);
        //        _creater.Remove(temp);
        //    }
        //}
        foreach(var temp in _visibled.ToList())
        {
            if (!temp.isVisible)
            {
                _visibled.Remove(temp);
                _free.Add(temp.gameObject);
            }
             
        }
    }
}
