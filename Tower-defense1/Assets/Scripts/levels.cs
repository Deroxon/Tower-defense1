using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System;

public class levels : MonoBehaviour
{
   
    public List<object> Levels = new List<object>();
    string json = File.ReadAllText("./JsonFiles/levels.json");



    public interface level
    {
       string Name { get; set; }
       int Level { get; set; }
       int Waves { get; set; }
       string[] Enemies { get; set; }

    }

    public class levelDetails : level {

        public string Name { get; set; }
        public int Level { get; set; }
        public int Waves { get; set; }
        public string[] Enemies { get; set;}
 

        public void setLevel(string name, int level, int waves, string[] enemies)
        {

            Name = name;
            Level = level;
            Waves = waves;
            Enemies = enemies;
           
        }
    
    }

    levelDetails ListOfLevels = JsonConvert.DeserializeObject<levelDetails>(File.ReadAllText("./JsonFiles/levels.json"));

    public void uruchom()
    {
        Console.Write(ListOfLevels.ToString());
    }


}
