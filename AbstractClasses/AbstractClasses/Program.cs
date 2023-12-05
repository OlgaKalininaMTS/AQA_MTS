// See https://aka.ms/new-console-template for more information

using AbstractClasses.Game;


Console.WriteLine("Hello, World!");

 Character[] characters = new Character[3];  // массив персонажей: общий тип данных (массив общего типа)

characters[0] = new Wizard(1);     // массив персонажей Wizard
characters[1] = new Warrior(1);
characters[2] = new Warrior(10);



foreach (var character in characters)
{
    character.Move();
    character.Attack();
    character.UseAbility();
    character.PrintInfo();
}
