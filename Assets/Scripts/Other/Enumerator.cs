using UnityEngine;

namespace Logic.Generic
{
    public class Enumerator
    {
        public float CountDownTime { get; set; }
        public float CurentTime { get; private set; }
        public Enumerator(float countDownTime)
        {
            CountDownTime = countDownTime;
            ResetEnumerator();
        }
        public bool CanDo()
        {
            CurentTime -= Time.deltaTime;

            if (CurentTime > 0)           
                return false;
            
            ResetEnumerator();
            return true;
        }
        public void ResetEnumerator()
        {
            CurentTime = CountDownTime;
        }
    }
}
