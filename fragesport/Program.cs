using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Net.Quic;
using System.Threading.Tasks.Dataflow;
bool play = true;
string answer;
string[] PA = {"A","B","C"};
string plays ="";
int QR;
string correctanswer="";


//starts the question phase

while(play == true){
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Welcome to the space quiz");
Console.ResetColor();

QR = 0;
question1();
question2();
question3();
question4();
question5();
//newquestion6();

Console.WriteLine($"You got {QR}/5 questions right.");
playagain();

}

void question1(){

Console.WriteLine("\nWhich planet in our solar system has the largest number of moons?");
Console.WriteLine("A: Saturn");
Console.WriteLine("B: Jupiter");
Console.WriteLine("C: Neptune");
CheckAnswer();
correctanswer = "A";
Correct();


}
void question2(){

Console.WriteLine("\nWhat is the name of saturns largest moon?");
Console.WriteLine("A: Ganymede");
Console.WriteLine("B: Titan");
Console.WriteLine("C: Callisto");
CheckAnswer();
correctanswer = "B";
Correct();

}
void question3(){

Console.WriteLine("\nWhich galaxy is the closest to our own (milky way)");
Console.WriteLine("A: Virgo-A");
Console.WriteLine("B: Andromeda");
Console.WriteLine("C: Maffei-1");
CheckAnswer();
correctanswer = "B";
Correct();

}
void question4(){

Console.WriteLine("\nWhich planet in our solar system is known for its distinctive blue color and strong winds");
Console.WriteLine("A: uranus");
Console.WriteLine("B: mercury");
Console.WriteLine("C: Neptune");
CheckAnswer();
correctanswer = "C";
Correct();

}
void question5(){

Console.WriteLine("\nWhich spacecraft made the first successful flyby of Pluto, providing valuable information about this distant dwarf planet?");
Console.WriteLine("A: Voyager 1");
Console.WriteLine("B: New horizons");
Console.WriteLine("C: Sputnik 1");
CheckAnswer();
correctanswer = "B";
Correct();

}
void newquestion6(){

Console.WriteLine("\n");  //question behind \n 
Console.WriteLine("A: ");   //alternative a
Console.WriteLine("B: ");   //alternative b
Console.WriteLine("C: ");    //alternative c
CheckAnswer();
correctanswer = "";  //the correct answer
Correct();      //checks if answer is correct or not

}
void playagain(){

Console.WriteLine("Do you wish to play again? y/n");
plays = Console.ReadLine().ToUpper();

if(plays == "Y"){
   play = true;
}else{
    play= false;
}

}
void CheckAnswer(){

while(true){
    answer = Console.ReadLine().ToUpper();       

if(PA.Contains(answer)){
    break;
}else{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Please write a possible answer");
    Console.ResetColor();
}
}

}
void Correct(){

if(answer.ToUpper() == correctanswer){
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Correct!");
    Console.ResetColor();
    QR++;
}else{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Incorrect!");
    Console.ResetColor();
} 
}   



Thread.Sleep(5000);



