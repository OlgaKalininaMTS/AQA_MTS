﻿// See https://aka.ms/new-console-template for more information

using Abstraction;

/*Corporate corporate1 = new Corporate();
corporate1.Id = 1;

Corporate corporate2 = new Corporate();
corporate2.Id = 1;

Console.WriteLine(corporate1.Id);
Console.WriteLine(corporate2.Id);
*/

Individual individual1 = new Individual(1);
individual1.PhoneNumber = "+375 29 12345678";
individual1.Email = "individual@test.com";
individual1.Firstname = "Иван";
individual1.Lastname = "Иванов";
individual1.Activate();
//
Individual individual2 = new Individual(2);


Corporate corporate1 = new Corporate(1);
corporate1.PhoneNumber = "+375 29 10000001";
corporate1.Email = "corporate1@test.com";
corporate1.INN = "123123123";
corporate1.UNP = "321321321";
corporate1.Activate();
corporate1.Pause();

Console.Out.WriteLine(individual1.Id);
Console.Out.WriteLine(individual1.PhoneNumber);
Console.Out.WriteLine(individual1.Lastname);

Console.Out.WriteLine(corporate1.Id);
Console.Out.WriteLine(corporate1.PhoneNumber);
Console.Out.WriteLine(corporate1.INN);
Console.Out.WriteLine(corporate1.INN);