using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Pcontro : MonoBehaviour
{
    public Animator anime_show,anime_info;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click_presonTab()
    {
        anime_show.SetBool("person_show", true);
        anime_info.SetBool("tab_close", false);

    }
    public void click_close()
    {
        anime_info.SetBool("tab_close", true);
        anime_show.SetBool("person_show", false);
        anime_info.SetBool("info_rota", false);

    }
    public void click_rota()
    {
        anime_info.SetBool("info_rota", !anime_info.GetBool("info_rota"));

    }
}
