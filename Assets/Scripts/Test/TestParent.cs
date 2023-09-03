using System;
using UnityEngine;

namespace Test
{
    public class TestParent : MonoBehaviour
    {
        public int value = 10;
        public float newValue = 15;

        private string text = "Text";
        
        private void Start()
        {
            var getValue = GetComponent<TestChild>().test;
            var getValue2 = GetComponent<TestChild>().test2;
            var getValue4 = GetComponent<TestChild>().test4;
            
            getValue4 = 5;
            getValue2 = 3;
            
            Debug.Log($"{getValue}");
            Debug.Log($"{getValue4}");
            Debug.Log($"{getValue2}");
        }

        public int ValueGet()
        {
            return value;
        }

        public string Test()
        {
            return text;
        }
    }
}