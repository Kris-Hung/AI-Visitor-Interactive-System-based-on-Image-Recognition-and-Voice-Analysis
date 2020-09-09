using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class map_control : MonoBehaviour
{
    private int line_count=7, place_count=4;

    public GameObject[] person_line = new GameObject[7];
    public GameObject[] place_line = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setNull()
    {
        for (int i = 0; i < line_count; i++)
        {
            person_line[i].SetActive(false);
        }

        for (int i = 0; i < place_count; i++)
        {
            place_line[i].SetActive(false);
        }
    }

    public void setLine( GameObject person_tab )
    {
        for (int i = 0; i < place_count; i++)
        {
            place_line[i].SetActive(false);
        }

        int temp = int.Parse(person_tab.transform.GetChild(1).gameObject.GetComponent<Text>().text);

        for (int i = 0; i < line_count; i++)
        {
            
            person_line[i].SetActive(false);

            if(i==temp)
                person_line[i].SetActive(true);

        }
    }

    public void setLine_fortalk(int temp)
    {
        for (int i = 0; i < place_count; i++)
        {
            place_line[i].SetActive(false);
        }

        for (int i = 0; i < line_count; i++)
        {

            person_line[i].SetActive(false);

            if (i == temp)
                person_line[i].SetActive(true);

        }
    }

    //panel 點擊
    public void setPanelplace(int temp)
    {
        for (int i = 0; i < line_count; i++)
        {
            person_line[i].SetActive(false);
        }

        for (int i = 0; i < place_count; i++)
        {

            place_line[i].SetActive(false);

            if (i == temp)
                place_line[i].SetActive(true);

        }
        

    }
    public void setPanelperson(int temp)
    {
        for (int i = 0; i < place_count; i++)
        {

            place_line[i].SetActive(false);
        }

        for (int i = 0; i < line_count; i++)
        {

            person_line[i].SetActive(false);

            if (i == temp)
                person_line[i].SetActive(true);

        }
    }
}
