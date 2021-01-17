using System;

namespace Task_003
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Music start playing \n");
        }

        public void Record()
        {
            Console.WriteLine("Start recording\n");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Recording Paused \n");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Recording Stopped \n");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Music Paused \n");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Music Stopped \n");
        }
    }
}