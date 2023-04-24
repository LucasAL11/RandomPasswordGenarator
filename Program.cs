Console.WriteLine("Pressione qualquer tecla para gerar um senha");

var password = Randomizers.GetRandomPassword(12);
var rngPassword = Randomizers.RngSecurityRandomizer(12);

Console.WriteLine($@" password: {password}, RngPassword: {rngPassword}");