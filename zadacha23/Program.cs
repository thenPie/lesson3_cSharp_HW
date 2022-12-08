int InputNum() {
    Console.Write("Input a number ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

void OutputCube(int num) {
    for(double i = 1; i <= num; i++) {
        double cube = Math.Pow(i, 3);
        Console.Write("{0} ", cube);
    }
}

OutputCube(InputNum());