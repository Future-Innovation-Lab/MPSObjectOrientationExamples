using System;
using NAudio.Wave;

namespace ObjectOrientation
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");

            /*   FOR SOUNDS UNCOMMENT

                               using (var audioFile = new AudioFileReader(".\\sounds\\woof.mp3"))
          using (var outputDevice = new WaveOutEvent())
          {
              outputDevice.Init(audioFile);
              outputDevice.Play();

              System.Threading.Thread.Sleep(5000);
          }
          */
        }
    }

}