using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{

    Transform objectTransform;
    public GameObject prefab;
    private GameObject[] objectPooling;

    void Start()
    {
        objectTransform = transform;

        objectPooling = new GameObject[1000];


        for (int i = 0; i < 1000; i++)
        {
            GameObject tempObject = Instantiate(prefab);
            tempObject.transform.position = new Vector3(1, 0, 1);
            objectPooling[i] = tempObject;
            tempObject.SetActive(false);
        }
    }

    void Update()
    {
        // TransformTest();
        //   ObjectAllocationTest();
        //    InstantiateTest();
        OptimisedInstantiateTest();

    }

    void TransformTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            objectTransform.position = Vector3.zero;

        }
    }

    void ObjectAllocationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            int myInt = 1;
            myInt++;
            int myOtherInt = myInt;

            ComplexObject tempObject = new ComplexObject();


        }

    }

    void InstantiateTest()
    {

        
        for (int i = 0; i < 1000; i++)
        {
            GameObject tempObject = Instantiate(prefab);
            tempObject.transform.position = new Vector3(1, 0, 1);
            Destroy(tempObject);
        }
    }


    void OptimisedInstantiateTest()
    {
        for (int i = 0; i < 1000; i++)
        {
            objectPooling[i].SetActive(true);
            objectPooling[i].transform.position = new Vector3(1, 0, 1);
            objectPooling[i].SetActive(false);
        }
        }
}
