int Ask() {
    Console.Write("Input a five-digit number: ");
    int num = int.Parse(Console.ReadLine());
    int count = num.ToString().Length;
    if (5 < count||5 > count) {
        return 123;
    } else {
        return num;
    }
}

void IsPalindrome(int num) {
    int reverse, t = num, total = 0;
    while (0 < num) {
        reverse = num % 10;
        total = (total * 10) + reverse;
        num = num / 10;
    }
    if (t == total) {
        Console.Write("It is a palindrome");
    } else {
        Console.Write("It is not a palindrome or a five digit number");
    }
}

IsPalindrome(Ask());