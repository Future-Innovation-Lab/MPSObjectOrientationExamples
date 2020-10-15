using System;
using NAudio.Wave;

namespace ObjectOrientation
{
    public class Pig : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Oink");

              /*   FOR SOUNDS UNCOMMENT

            using (var audioFile = new AudioFileReader(".\\sounds\\pig.mp3"))
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