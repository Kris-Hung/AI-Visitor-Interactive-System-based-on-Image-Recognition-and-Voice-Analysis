using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_control : MonoBehaviour
{
    //anime control
    public Animator anime, anime2, anime3, anime4;
    public bool check, check2, check3, check4, Icheck = false, ITwocheck = false, Talkcheck = false, Talkcheck2 = false; //
    private string[] anim_arry = new string[5] { "idle", "test1", "test2", "intro", "123" };
    private string[] anim_bool = new string[3] { "talk0", "hello0", "intro0" };
    private float idle = 0.0f, talk = 0.0f, R_time = 0.0f;
    private int iIdle, iTalk;

    //face control
    public GameObject aj_mouth, aj_eyes, pickachu_face;
    private Material[] mat, mat2, mat3;
    private int mouth_talk, eyes_wink;
    public bool mouth_call;
    public Vector2 v2;
    public float positionX, positionY;

    public GameObject unitychan;

    private Transform Face_Nose;
    public GameObject OpenPose;
    public Transform[] EyeTrace;


    // Start is called before the first frame update
    void Start()
    {
        //face control
        mat = aj_mouth.GetComponent<Renderer>().materials;
        mat2 = aj_eyes.GetComponent<Renderer>().materials;
        mat3 = pickachu_face.GetComponent<Renderer>().materials;
        mouth_talk = 0;
        eyes_wink = 0;
        mouth_call = false;
        Face_Nose = new GameObject().transform; //防止亂看
    }

    // Update is called once per frame
    void Update()
    {

        EyeTrace = OpenPose.GetComponentsInChildren<Transform>();

        if (EyeTrace[5].transform.name == "0_Nose")
        {
            if (Face_Nose.transform.name != "0_Nose") //防止亂看
            {
                Face_Nose = EyeTrace[5];
            }
            positionX = Face_Nose.transform.position.x;
            positionY = Face_Nose.transform.position.y;
        }
        else //眼睛歸零
        {
            positionX = 0;
            positionY = 0;
        }
        //face control
        if (mouth_call) mouth();
        //Debug.Log(v2);
        eyes();




        //anime control
        R_time = R_time + 0.1f * 0.08f;
        if (R_time >= 5.0f)
        {
            random_float();
            if(anime.GetBool("hello0") == false && anime.GetBool("intro0") == false )
                random_set();

            if(anime2.GetBool("hello0") == false && anime2.GetBool("intro0") == false)
                random_set();

            if (anime3.GetBool("hello0") == false && anime3.GetBool("intro0") == false)
                random_set();

            if (anime4.GetBool("hello0") == false && anime4.GetBool("intro0") == false)
                random_set();

            R_time = 0.0f;

        }
        if (Icheck==true)
        {
            if (idle <= iIdle)
            {
                idle = idle + 0.1f * 0.2f;
                anime.SetFloat("idle", (float)idle);
                anime2.SetFloat("idle", (float)idle);
                anime3.SetFloat("idle", (float)idle);
                anime4.SetFloat("idle", (float)idle);
            }
            else Icheck = false;

        }
        if (ITwocheck == true)
        {
            if (idle >= iIdle)
            {
                idle = idle - 0.1f * 0.2f;
                anime.SetFloat("idle", (float)idle);
                anime2.SetFloat("idle", (float)idle);
                anime3.SetFloat("idle", (float)idle);
                anime4.SetFloat("idle", (float)idle);
            }
            else ITwocheck = false;

        }

        if (Talkcheck == true)
        {
            if (talk <= iTalk)
            {
                talk = talk + 0.1f * 0.2f;
                anime.SetFloat("talk", (float)talk);
                anime2.SetFloat("talk", (float)talk);
                anime3.SetFloat("talk", (float)talk);
                anime4.SetFloat("talk", (float)talk);
            }
            else Talkcheck = false;

        }
        if (Talkcheck2 == true)
        {
            if (talk >= iTalk)
            {
                talk = talk - 0.1f * 0.2f;
                anime.SetFloat("talk", (float)talk);
                anime2.SetFloat("talk", (float)talk);
                anime3.SetFloat("talk", (float)talk);
                anime4.SetFloat("talk", (float)talk);
            }
            else Talkcheck2 = false;

        }


    }



    /*可調用函式*/


    //控制嘴巴開合
    /*public void control_mouth(string call)   //input strat/end : 開始說話/停止說話
    {
        switch (call)
        {
            case "strat":
                mouth_call = true;
                break;

            case "end":
                mouth_call = false;
                break;
        }


    }*/



    /*不可調用函式*/
    void mouth()
    {
        mouth_talk = mouth_talk + 1;

        if (mouth_talk == 15)
        {
            mat[0].SetTextureOffset("_MainTex", new Vector2(0.1f, 0.5f));
            unitychan.GetComponent<FaceUpdate>().OnCallChangeFace("MTH_A");
            mat3[2].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.75f));
            //Debug.Log(mouth_talk);

        }
        else if (mouth_talk == 30)
        {
            unitychan.GetComponent<FaceUpdate>().OnCallChangeFace("MTH_E");
            mat[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.0f));
            mat3[2].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.75f));
        }
        else if (mouth_talk == 45)
        {
            mat[0].SetTextureOffset("_MainTex", new Vector2(0.1f, 0.5f));
            unitychan.GetComponent<FaceUpdate>().OnCallChangeFace("MTH_A");
            mat3[2].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.75f));
        }
        else if (mouth_talk >= 60)
        {
            mat[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.0f));
            unitychan.GetComponent<FaceUpdate>().OnCallChangeFace("MTH_E");
            mat3[2].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.0f));
            mouth_talk = 0;
        }
    }

    void eyes()
    {
        eyes_wink = eyes_wink + 1;

        if (eyes_wink < 120)
        {
            /*x : -90~90*/
            /*y : -65~65*/
            if (positionX > 40)
            {
                if (positionX > 80)
                    mat2[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.8f));

                else
                    mat2[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.9f));
            }
            else if (positionX < -40)
            {
                if (positionX < -80)
                    mat2[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.6f));
                else
                    mat2[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.7f));
            }
            else
            {
                if (positionY > 45)
                    mat2[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.5f));
                else if (positionY < -40)
                    mat2[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.3f));
                else
                    mat2[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.0f));
            }


        } //mat2[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.0f));
        else if (eyes_wink == 120) mat2[0].SetTextureOffset("_MainTex", new Vector2(0.2f, 0.8f));
        else if (eyes_wink == 125)
        {
            mat2[0].SetTextureOffset("_MainTex", new Vector2(0.2f, 0.8f));
            eyes_wink = 0;

        }
    }

    public void changeHaveP(bool have)//是否有人
    {
        anime.SetBool("people_have", have);
        anime2.SetBool("people_have", have);
        anime3.SetBool("people_have", have);
        anime4.SetBool("people_have", have);
    }



    public void changeState(string state) //開始做什麼動作
    {
        switch (state)
        {
            case "idle":
                //anime.SetFloat(anim_arry[0],f_idle);
                mouth_call = false;
                mat[0].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.0f));
                unitychan.GetComponent<FaceUpdate>().OnCallChangeFace("default@unitychan");
                mat3[2].SetTextureOffset("_MainTex", new Vector2(0.0f, 0.0f));
                clear_allbool();
                break;

            case "talk":
                mouth_call = true;
                check = !anime.GetBool("talk0");
                check2 = !anime2.GetBool("talk0");
                check3 = !anime3.GetBool("talk0");
                check4 = !anime4.GetBool("talk0");
                anime.SetBool(anim_bool[0], check);
                anime2.SetBool(anim_bool[0], check2);
                anime3.SetBool(anim_bool[0], check3);
                anime4.SetBool(anim_bool[0], check4);
                break;

            case "hello":
                mouth_call = true;
                check = !anime.GetBool("hello0");
                check2 = !anime2.GetBool("hello0");
                check3 = !anime3.GetBool("hello0");
                check4 = !anime4.GetBool("hello0");
                anime.SetBool(anim_bool[1], check);
                anime2.SetBool(anim_bool[1], check2);
                anime3.SetBool(anim_bool[1], check3);
                anime4.SetBool(anim_bool[1], check4);
                break;

            case "intro":
                mouth_call = true;
                check = !anime.GetBool("intro0");
                check2 = !anime2.GetBool("intro0");
                check3 = !anime3.GetBool("intro0");
                check4 = !anime4.GetBool("intro0");
                anime.SetBool(anim_bool[2], check);
                anime2.SetBool(anim_bool[2], check2);
                anime3.SetBool(anim_bool[2], check3);
                anime4.SetBool(anim_bool[2], check4);
                break;
        }
            
    }

    public void random_set() //改變intro,hello動作
    {
        Random.seed = System.Guid.NewGuid().GetHashCode();
        int iHello = Random.Range(0, 3);
        int iIntro = Random.Range(0, 5);
        anime.SetFloat("hello", (float)iHello);
        anime.SetFloat("intro", (float)iIntro);
        anime2.SetFloat("hello", (float)iHello);
        anime2.SetFloat("intro", (float)iIntro);
        anime3.SetFloat("hello", (float)iHello);
        anime3.SetFloat("intro", (float)iIntro);
        anime4.SetFloat("hello", (float)iHello);
        anime4.SetFloat("intro", (float)iIntro);
    }

    public void random_float() //改變idle,talk動作
    {
        idle = (int)anime.GetFloat("idle");
        talk = (int)anime.GetFloat("talk");
        Random.seed = System.Guid.NewGuid().GetHashCode();
        do
        {
            iIdle = Random.Range(0, 3);
            iTalk = Random.Range(0, 3);

        } while (iIdle == idle || iTalk == talk);

        //Debug.Log("Random:"+iIdle);
        //Debug.Log("Or: " + idle);

        if (iIdle > idle)
            Icheck = true;
        else
            ITwocheck = true;

        if (iTalk > talk)
            Talkcheck = true;
        else
            Talkcheck2 = true;
    }



    /*清除所有動作*/
    private void clear_allbool()
    {
        for (int i = 0; i < 3; i++)
        {
            anime.SetBool(anim_bool[i], false);
            anime2.SetBool(anim_bool[i], false);
            anime3.SetBool(anim_bool[i], false);
            anime4.SetBool(anim_bool[i], false);
        }
    }
}
