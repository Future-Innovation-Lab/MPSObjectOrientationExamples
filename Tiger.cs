using NAudio;
using NAudio.Wave;
using System;

namespace ObjectOrientation
{
    public class Tiger : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("ROAR");

            /*   FOR SOUNDS UNCOMMENT
               using (var audioFile = new AudioFileReader(".\\sounds\\tiger.mp3"))
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