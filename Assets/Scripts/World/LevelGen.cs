using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    [SerializeField] GameObject Plane;
    [SerializeField] GameObject FireTrap;
    [SerializeField] GameObject SpikeTrap;
    [SerializeField] GameObject SmallAxeTrap;
    [SerializeField] GameObject BigAxeTrap;
    [SerializeField] GameObject Coin;

    private int PlaneTypes = 4;

    private void Awake()
    {
    }

    public GameObject GeneratePlane(Vector3 position)
    {
        //Plane plane = Instantiate(new Plane(), position, Quaternion.identity);
        GameObject plane = Instantiate(Plane, position, Quaternion.identity);
        plane.transform.position = position;

        switch(Random.Range(0, PlaneTypes))
        {
            case 0: FillStandartPlane(plane); break;
            case 1: FillStandartPlane(plane); break;
            case 2: FillBigAxePlane(plane); break;
            case 3: FillSmallAxePlane(plane); break;
        }

        return plane;
    }

    private void FillStandartPlane(GameObject plane)
    {
        //int layerMask = 1 << 8;
        Vector3 pos;


        for (int i=-4; i<=4; i+=2)
        {
            var enemy = Instantiate(FireTrap, plane.transform);
            pos = new Vector3(Random.Range(-13f, 13f), 0, i);
            enemy.transform.Translate(pos);
        }
        for (int i = -4; i <= 4; i+=2)
        {
            var enemy = Instantiate(SpikeTrap, plane.transform);
            pos = new Vector3(Random.Range(-13f, 13f), 0, i);
            enemy.transform.Translate(pos);
        }
    }

    private void FillMoneyPlane(GameObject plane)
    {

    }

    private void FillSmallAxePlane(GameObject plane)
    {
        var leftRight = Random.Range(0, 2) == 0 ? 1 : -1;

        for(int i = -4; i <= 4; i+=2)
        {
            var enemy = Instantiate(SmallAxeTrap, plane.transform);
            enemy.transform.Translate(new Vector3(Random.Range(-12f, 12f), 0, i));
        }
    }

    private void FillBigAxePlane(GameObject plane)
    {
        for (int i = -5; i <= 5; i += 10)
        {
            var enemy = Instantiate(BigAxeTrap, plane.transform);
            enemy.transform.Translate(new Vector3(Random.Range(-5f, 5f) + i , 5, 0));
        }
    }

    private void FillEmptyPlane(GameObject plane)
    {

    }
}
