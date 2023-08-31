using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Checker
{
    public static bool isLoadedToStartScene = false;
}

public class SceneChacker : MonoBehaviour
{//해당 스크립트에서는 프리팹을 만들고 메인씬과, 플레이씬 하이어라키에 프리팹을 넣어야한다.
 //메인씬 하이어라키에 있는 프리팹은 체크를 해주고 플레이씬 하이어라키에 있는 프리팹은 체크를 해제한다.
 //메인씬에 있는 프리팹에 체크박스에 체크를 하지 않으면 유니티가 멈춘다.
    public bool startScene = false;

    private void Awake()
    {
        if (startScene == true)
        {
            Checker.isLoadedToStartScene = true;
        }

        if (Checker.isLoadedToStartScene == false)
        {
            SceneManager.LoadScene((int)SceneIndex.mainScene);
        }
    }
}

