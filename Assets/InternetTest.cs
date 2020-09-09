using System.Collections;
using System.Net.NetworkInformation;
using UnityEngine;


public class InternetTest
{
    public static void Test()
    {
        GameObject NetTest = GameObject.Find("Warning");
        NetTest.SetActive(true);
    }
}
