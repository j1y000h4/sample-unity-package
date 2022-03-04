using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IMFINE.Tools
{
    public class SampleToolKit : MonoBehaviour
    {
        private string testText = "테스트입니다.";

        private void Start()
        {
            Debug.Log("테스트");
        }

        private void SetTestText(string _text)
        {
            testText = _text;
        }

        public string _testText
        {
            get { return testText; }
        }
    }
}
