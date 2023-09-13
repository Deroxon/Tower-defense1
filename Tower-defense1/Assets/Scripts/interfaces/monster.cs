using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface Monster
{
    string Name { get; set; }
    float healthPoints { get; set; }
    float currentHealthPoints { get; set; }
    float moveSpeed { get; set; }
    float damage { get; set; }

    string sprite { get; set; }



}

public class MonsterClass : Monster
{
    public string Name { get; set; }
    public float healthPoints { get; set; }
    public float currentHealthPoints { get; set; }
    public float moveSpeed { get; set; }
    public float damage { get; set; }

    public string sprite { get; set; }



}

public class MonsterData
{
    public MonsterClass[] monsters;
}