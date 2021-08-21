using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

MooseSays("I'm a magical moose!");

// As a question
// MooseAsks("Ask me a question and I'll tell you whe it's true.");

class Program
{

    private static List<Answer> _answers = new List<Answer>
    {
        new Answer { Id = 1, Text = "As I see it, yes." },
        new Answer { Id = 2, Text = "Ask again later." },
        new Answer { Id = 3, Text = "Better not tell you now." },
        new Answer { Id = 4, Text = "Cannot predict now." },
        new Answer { Id = 5, Text = "Concentrate and ask again." },
        new Answer { Id = 6, Text = "Don’t count on it." },
        new Answer { Id = 7, Text = "It is certain." },
        new Answer { Id = 8, Text = "It is decidedly so." },
        new Answer { Id = 9, Text = "Most likely." },
        new Answer { Id = 10, Text = "My reply is no." },
        new Answer { Id = 11, Text = "My sources say no." },
        new Answer { Id = 12, Text = "Outlook not so good." },
        new Answer { Id = 13, Text = "Outlook good." },
        new Answer { Id = 14, Text = "Reply hazy, try again." },
        new Answer { Id = 15, Text = "Signs point to yes." },
        new Answer { Id = 16, Text = "Very doubtful." },
        new Answer { Id = 17, Text = "Without a doubt." },
        new Answer { Id = 18, Text = "Yes." },
        new Answer { Id = 19, Text = "Yes – definitely." },
        new Answer { Id = 20, Text = "You may rely on it." },
    };


    static void Main(string answer)
    {
        Console.Write($"{answer}");
        string question = Console.ReadLine().ToLower();

        while (question != "")
        {
            Console.Write($"{answer}");
            answer = Console.ReadLine().ToLower();
        }
        var answers = MooseAnswer();

        if (question != "")
        {
            Console.WriteLine(answer.Text); ;
        }
        else
        {
            return false;
        }
    }


    string MooseAnswer = GetAnswers(int id)
    {
        Random r = new Random();
    int genRand = r.Next(10, 50);

    private static List<Answer> GetAnswers(int Id)
    {
        var answers = _answers.Where(a => a.genRad == Id).ToList();
        return answers;
    }

}
};




void MooseSays(string message)
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
               '-'    | /       \ |       My crystal ball says:
                      |  .-. .-.  |       {message}
                      \ / o| |o \ /
                       |   / \   |              _...._   
                      / `^`   `^` \           .`      `.
                     /             \         / ***      \  
                    | '._.'         \       : **         :  
                    |  /             |      :            :   
                     \ |             |       \          / 
                      ||    _    _   /        `-.,,,,.-'  
                      /|\  (_\  /_) /          _(    )_
                      \ \'._  ` '_.'          )        (
                       `^^` `^^^`            (          )
                                              `-......-`
   ");
};




