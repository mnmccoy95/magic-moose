using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Magic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Ask a question
            AskMoose("Ask me a question!");
        }

        static void AskMoose(string message)
        {
            Console.WriteLine($@"
                                                _.--^^^--,
                                                .'          `\
            .-^^^^^^-.                      .'              |
            /          '.                   /            .-._/
            |             `.                |             |
            \              \          .-._ |          _   \
            `^^'-.         \_.-.     \   `          ( \__/
                    |             )     '=.       .,   \
                /             (         \     /  \  /
                /`               `\        |   /    `'
                '..-`\        _.-. `\ _.__/   .=.
                    |  _    / \  '.-`    `-.'  /
                    \_/ |  |   './ _     _  \.'
                        '-'    | /       \ |
                                |  .-. .-.  |
                                \ / o| |o \ /
                                |   / \   |    {message}
                                / `^`   `^` \
                                /             \
                                | '._.'         \
                                |  /             |
                                \ |             |
                                ||    _    _   /
                                /|\  (_\  /_) /
                                \ \'._  ` '_.'
                                `^^` `^^^`
            ");
            Console.Write(":");
            string answer = Console.ReadLine();
        }
    }
}