// PART 1

// Random rnd = new Random();
// int number = rnd.Next(1, 11);

// Console.WriteLine("Please guess a number between 1-10:");
// var input = Console.ReadLine();
// var guess = int.Parse(input);

// if (guess == number) {
//     Console.WriteLine("You guessed correctly!");
// }
// else {
//     Console.WriteLine($"You didn't guess correctly! The answer was {number}");
// }

// PART 2

// Random rnd = new Random();
// int number = rnd.Next(1, 11);

// int count = 1;

// while (count <= 3) {
//     Console.WriteLine("Please guess a number between 1-10:");
//     var input = Console.ReadLine();
//     var guess = int.Parse(input);

//     if (guess == number) {
//         Console.WriteLine("You guessed correctly!");
//     }
//     else {
//         Console.WriteLine($"You didn't guess correctly! Try again");
//     }
//     count ++;
// }

// if (count == 4) {
//     Console.WriteLine($"Too bad, you lost. The answer was {number}");
// }

// EXTENSION

Random rnd = new Random();
int number = rnd.Next(1, 11);

var incorrect = true;

while (incorrect) {
    Console.WriteLine("Please guess a number between 1-10:");
    var input = Console.ReadLine();
    var guess = int.Parse(input);

    if (guess == number) {
        Console.WriteLine("You guessed correctly!");
        break;
    }
    else {
        Console.WriteLine($"You didn't guess correctly! Try again");
    }
}
