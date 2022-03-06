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
        int layerMask = 1 << 8;
        Vector3 pos;


        for (int i=0; i<2; i++)
        {
            var enemy = Instantiate(FireTrap, plane.transform);
            int steps = 0;
            //do
            //{
                pos = new Vector3(Random.Range(-3.5f, 3.5f), 0, Random.Range(-3.5f, 3.5f));
                steps++;
            //}
            //while (!Physics.CheckSphere(enemy.transform.position+pos, 2) || steps>10);

            Debug.Log(steps);
            enemy.transform.Translate(pos);
        }
        for (int i = 0; i < 2; i++)
        {
            var enemy = Instantiate(SpikeTrap, plane.transform);
            int steps = 0;
            //do
            //{
                pos = new Vector3(Random.Range(-3.5f, 3.5f), 0, Random.Range(-3.5f, 3.5f));
                steps++;
            //}
            //while (!Physics.CheckSphere(pos, 1, layerMask) || steps > 10);

            enemy.transform.Translate(pos);
        }
    }

    private void FillMoneyPlane(GameObject plane)
    {

    }

    private void FillSmallAxePlane(GameObject plane)
    {
        var leftRight = Random.Range(0, 2) == 0 ? 1 : -1;

        var enemy1 = Instantiate(SmallAxeTrap, plane.transform);
        var enemy2 = Instantiate(SmallAxeTrap, plane.transform);

        enemy1.transform.Translate(new Vector3(4 * leftRight, 0, 5 ));
        enemy2.transform.Translate(new Vector3(-4 * leftRight, 0, -5));
    }

    private void FillBigAxePlane(GameObject plane)
    {
        var enemy = Instantiate(BigAxeTrap, plane.transform);
        var leftRight = Random.Range(0, 2)==0 ? 1 : -1;

        enemy.transform.Translate(new Vector3(3 * leftRight, 4.5f , Random.Range(-3.5f, 3.5f) ));
    }

    private void FillEmptyPlane(GameObject plane)
    {

    }
}
