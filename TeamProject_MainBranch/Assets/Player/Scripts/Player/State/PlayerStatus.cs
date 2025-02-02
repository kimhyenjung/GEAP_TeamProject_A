using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int hp = 100;

    public int hp_max = 100;
    [SerializeField]
    int damage = 5;

    [SerializeField]
    public bool isInDefenceArea = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getPlayerHP()
    {
        return hp;
    }

    public int getPlayerDamage()
    {
        return damage;
    }

    public void setPlayerDamage(int iValue)
    {
        damage = iValue;
    }


    public void HealPlayer(int value)
    {
        hp += value;
        if (hp > hp_max)
            hp = hp_max;

        Debug.Log("heal");
    }

    // 데미지를 입을 함수 설정
    void AttackPlayer(int damage)
    {

        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
        }
    }
}