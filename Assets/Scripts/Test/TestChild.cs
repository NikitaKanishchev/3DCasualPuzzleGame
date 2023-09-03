using UnityEngine;

namespace Test
{
    public class TestChild : MonoBehaviour
    {
        public int test = 3;
        public int test2 { get; set; } = 2;
        public int test3 { private get; set; } = 2;
        public int test4 { get; private set; } = 2;
        
        public GameObject testGameObject;
        
        public int GetValue()
        {
            return 25;
        }
    }
}