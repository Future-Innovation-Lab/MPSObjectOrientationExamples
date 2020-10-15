using NAudio.Wave;
using System;

namespace ObjectOrientation
{
    public class Rhino : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("RHINO SOUNDS");

            /*   FOR SOUNDS UNCOMMENT
           using (var audioFile = new AudioFileReader(".\\sounds\\rhinos4.mp3"))
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