using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceenChanger : MonoBehaviour
{

    [SerializeField] private MeshRenderer _player;
    [SerializeField] private Material[] _materials;

    public MeshRenderer Player
    {
        get { return _player; }
        set { _player = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            Material[] mats = new Material[] { _materials[Random.Range(0, _materials.Length)] };

            _player.materials = mats;
            Debug.Log(mats);
            Debug.Log(_materials[Random.Range(0, _materials.Length)]);
        }
    }
}
