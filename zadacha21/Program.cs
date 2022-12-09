// int Input1() {
//     Console.Write("Give coords of a dot split with spaces in a 3D space: ");
//     var FirstCoord = Console.ReadLine();
//     var space = FirstCoord.Split(" ");
//     int x1 = int.Parse(space[0]);
//     int y1 = int.Parse(space[1]);
//     int z1 = int.Parse(space[2]);
    
//     return x1, y1, z1;
// }

// int Input2() {
//     Console.Write("Give coords of a second dot split with spaces in a 3D space: ");
//     var SecondCoord = Console.ReadLine();
//     var space = SecondCoord.Split(" ");
//     int x2 = int.Parse(space[0]);
//     int y2 = int.Parse(space[1]);
//     int z2 = int.Parse(space[2]);
    
//     return x2, y2, z2;
// }

// Input();

// void Input() {
//     var coord = Console.ReadLine();
//     var space = coord.Split(" ");
//     int x = int.Parse(space[0]);
//     int y = int.Parse(space[1]);
//     int z = int.Parse(space[2]);

//     int[] Aint = Array.ConvertAll(coord, c => (int)Char.GetNumericValue(c));
//     Console.WriteLine(Aint);
// }

// Input();

// void Ask(int x1, y1, z1, x2, y2, z2) {
//     Console.Write("Give coords of a dot split with spaces in a 3D space: ");
//     Console.WriteLine(coord1 + coord2);
// }

// Ask(Input1(), Input2());

//Absolute fail, don't look up

Console.Write("Give coords of a dot split with spaces in a 3D space: ");

// can probably make a method of it instead of almost copy-pasting this two times but I don't have enough time
var FirstCoord = Console.ReadLine();
var space1 = FirstCoord.Split(" ");
int x1 = int.Parse(space1[0]);
int y1 = int.Parse(space1[1]);
int z1 = int.Parse(space1[2]);

Console.Write("Give coords of a second dot split with spaces in a 3D space: ");

var SecondCoord = Console.ReadLine();
var space2 = SecondCoord.Split(" ");
int x2 = int.Parse(space2[0]);
int y2 = int.Parse(space2[1]);
int z2 = int.Parse(space2[2]);

var distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
Console.Write(distance);