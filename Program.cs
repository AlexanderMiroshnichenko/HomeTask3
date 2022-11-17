using System;
using System.Collections.Generic;

namespace HomeTask3
{
    class Program
    {
        public class Wheel
        {
            private float _wheelRadius;
            private float _springTravel;
            private float _springStiffness;
            private float _motorTorque;

            public Wheel(float wheelRadius, float springTravel, float springStiffness, float motorTorque)
            {
                this._wheelRadius = wheelRadius;
                this._springTravel = springTravel;
                this._springStiffness = springStiffness;
                this._motorTorque = motorTorque;

            }

            public void Rotate()
            {
                Console.WriteLine("ROTATING....\n");
            }
            
            public void GetStats()
            {
               
                Console.WriteLine("Wheel radius: " + _wheelRadius+"\nSpring travel: "+_springTravel+ "\nSpring stiffness: "+ _springStiffness+"\nMotor torque: "+_motorTorque);

            }

        }
        static void Main() {

            List<Wheel> Wheels = new List<Wheel>();

            Wheel wheelFrontLeft = new Wheel(9.5f,1f,200000f,0f);
            Wheel wheelFrontRight = new Wheel(9.5f, 1f, 200000f, 0f);
            Wheel wheelRareLeft = new Wheel(10f, 1f, 200000f, 1000f);
            Wheel wheelRareRight = new Wheel(10f, 1f, 200000f, 1000f);

            Wheels.Add(wheelFrontLeft);
            Wheels.Add(wheelFrontRight);
            Wheels.Add(wheelRareLeft);
            Wheels.Add(wheelRareRight);

            foreach(Wheel wheel in Wheels)
            {  
                wheel.GetStats();
                wheel.Rotate();
            }

          



        }
         
    }
        
          
   
        
    

}