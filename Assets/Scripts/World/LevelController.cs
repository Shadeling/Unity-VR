using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LevelGen))]
public class LevelController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] int planeCount = 6;
    [SerializeField] float distanceToGenerate = 30;
    

    private List<GameObject> _planes = new List<GameObject>();
    private LevelGen _generator;
    private Vector3 _currentPos = Vector3.zero;

    void Start()
    {
        _generator = GetComponent<LevelGen>();
        for(int i=0; i<planeCount; i++)
        {
            RegenerateNewPlane(false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerTransform.position.z > _planes[0].transform.position.z + distanceToGenerate)
        {
            RegenerateNewPlane(true);
        }
    }

    private void RegenerateNewPlane(bool delete)
    {
        if(delete)
        {
            Destroy(_planes[0]);
            _planes.RemoveAt(0);
        }
        _planes.Add(_generator.GeneratePlane(_currentPos));
        _currentPos.z = _currentPos.z + 10;
    }
}
