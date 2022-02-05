using System;
using UnityEngine;
using System.IO;
using ObjectsDefinition;

namespace DataManagement
{
    [Serializable]
    public class Request
    {
        public Point position;
        public uint radius;

        public Request(Point _position, uint _radius)
        {
            position = _position;
            radius = _radius;
        }
        public Request()
        {

        }
        public static void encode(Request req)
        {
            string str = JsonUtility.ToJson(req, true);
            File.WriteAllText(Path.Combine(Application.dataPath, "Resources/request.json"), str);
        }

        public string encode()
        {
            return JsonUtility.ToJson(this);
        }
    }
}