using System;

namespace Task_003
{
    class PlayerMenu
    {
        private readonly Player _player = new Player();
        public void PlayerMenuChooser()
        {
            Console.Write("Welcome to new SuperSoundPlayer v02.01\n");
            Console.WriteLine("Please Choose action: 1 Listen music, 2 Record Music, 0 - Left this program");
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    Console.WriteLine("Thank you for using our Player");
                    break;
                case "1":
                    PlayerPlayingMenu();
                    break;
                case "2":
                    PlayerRecordingMenu();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }

        private void PlayerPlayingMenu()
        {
            string choise = default;
            IPlayable playable = _player as IPlayable;

            while (choise !="0")
            {
                Console.WriteLine("Playing Section. Please define action: 1 - Play, 2 - Pause, 3 - Stop, 0 - Exit ...");
                choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        playable.Play();
                        break;
                    case "2":
                        playable.Pause();
                        break;
                    case "3":
                        playable.Stop();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Wrong input, please repeat");
                        Console.Clear();
                        break;
                }
            }
        }

        private void PlayerRecordingMenu()
        {
            string choise = default;
            IRecodable recordable = _player as IRecodable;

            while (choise != "0")
            {
                Console.WriteLine("Playing Section. Please define action: 1 - Play, 2 - Pause, 3 - Stop, 0 - Exit ...");
                choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        recordable.Record();
                        break;
                    case "2":
                        recordable.Pause();
                        break;
                    case "3":
                        recordable.Stop();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Wrong input, please repeat");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}