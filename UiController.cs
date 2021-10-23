using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class UiController : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        private float h;
        private float v;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void Update()
        {
            // pass the input to the car!
            pushLeft();
            pushRight();
            pushDown();
            pushUp();
            m_Car.Move(h, v, v, 0f);
        }

        public void pushLeft()
        {
            h = Mathf.Clamp(h - 1, -1, 1);
        }

        public void pushRight()
        {
            h = Mathf.Clamp(h + 1, -1, 1);
        }

        public void pushDown()
        {
            v = Mathf.Clamp(v - 1, -1, 1);
        }

        public void pushUp()
        {
            v = Mathf.Clamp(v + 1, -1, 1);
        }
    }
}
