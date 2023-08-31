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
{//�ش� ��ũ��Ʈ������ �������� ����� ���ξ���, �÷��̾� ���̾��Ű�� �������� �־���Ѵ�.
 //���ξ� ���̾��Ű�� �ִ� �������� üũ�� ���ְ� �÷��̾� ���̾��Ű�� �ִ� �������� üũ�� �����Ѵ�.
 //���ξ��� �ִ� �����տ� üũ�ڽ��� üũ�� ���� ������ ����Ƽ�� �����.
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

