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

        Debug.Log(CompareStrings("Yes", "No"));
        string value1 = "Yes";
        string value2 = "No";
        int string1 = value1.GetHashCode();
        int string2 = value2.GetHashCode();
        Debug.Log(CompareStrings(string1, string2));
    }

    void Update()
    {
        // TransformTest();
        //   ObjectAllocationTest();
        //    InstantiateTest();
        OptimisedInstantiateTest();

    }

    private void RandomValues(float[] arrayToFill)
    {
        for (int i = 0; i < arrayToFill.Length; i++)
        {
            arrayToFill[i] = Random.value;
        }
    }

    private float[] RandomValues(int numOfValues) // the problem with this is when the method ends the array on the stack is deleted then garabge collect will frame rate
    {
        var numberList = new float[numOfValues]; // var is a type that is not defined yet. Sometimes you don't know what type of variable it is before run time

        for (int i = 0; i < numOfValues; i++)
        {
            numberList[i] = Random.value;
        }

        return numberList;
    }

    private bool CompareStrings(string string1, string string2) // this way would use a hash value as opposed to comparing character by character much quicker.
    {
        // Compare tag, compare object name, find objects by tag, Camera.main.transform; anything else that will be comparing strings will be rather slow

        if (string1 == string2)
        {
            return true;
        }
        else
        {
            return false;
        }


    }

    private bool CompareStrings(int string1, int string2)
    {
        if (string1 == string2)
        {
            return true;
        }
        else
        {
            return false;
        }


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
