using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    [SerializeField] GameObject Plane;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameObject Rock;
    [SerializeField] GameObject Coin;

    private int PlaneTypes = 1;

    
    public GameObject GeneratePlane(Vector3 position)
    {
        //Plane plane = Instantiate(new Plane(), position, Quaternion.identity);
        GameObject plane = Instantiate(Plane, position, Quaternion.identity);
        plane.transform.position = position;

        switch(Random.Range(0, PlaneTypes))
        {
            case 0: FillStandartPlane(plane); break;
            case 1: FillMoneyPlane(plane); break;
        }

        return plane;
    }

    private void FillStandartPlane(GameObject plane)
    {
        for(int i=0; i<2; i++)
        {
            var enemy = Instantiate(Enemy, plane.transform);
            //enemy.transform.localPosition = Vector3.zero;
            enemy.transform.Translate(new Vector3(Random.Range(-4f, 5f), 0, Random.Range(-4f, 5f)));
        }
        for (int i = 0; i < 3; i++)
        {
            var enemy = Instantiate(Rock, plane.transform);
            //enemy.transform.localPosition = Vector3.zero;
            enemy.transform.Translate(new Vector3(Random.Range(-4f, 5f), 0, Random.Range(-4f, 5f)));
        }
    }

    private void FillMoneyPlane(GameObject plane)
    {

    }
}
