Console.WriteLine("STATUSIS TRIKAMPIS");
Console.WriteLine();

// Apsirašau turimus du kintamuosiuos 

var aKrastine = 10;
var bKrastine = 15;

// Pasirašau pagal kokia formule skaičiuosiu

Console.WriteLine("Pitagoro teorema - c*2 = b*2 + a*2");
Console.WriteLine();

// Atlieku matematinį veiksmą pagal pitagoro teoremą

double cKrastine = Math.Sqrt((aKrastine * aKrastine + bKrastine * bKrastine));

// Išvedu gautą atsakymą user'iui

Console.WriteLine($"Jūsų a kraštinės ilgis yra : {aKrastine}");
Console.WriteLine($"Jūsų b kraštinės ilgis yra : {bKrastine}");
Console.WriteLine();
Console.WriteLine($"Jūsų įžambinės ilgis yra : {cKrastine}");

var Kintamasis3 = cKrastine;
