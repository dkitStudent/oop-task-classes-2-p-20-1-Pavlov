using oop_task_2_console.Core;

Converter converter = new Converter(btc: 2_023_536.96, eth: 97_871.55, bnb: 37_543.23);

double rubles = 1000;
double btc = 1.5;

Console.WriteLine($"{rubles} рублей в\n" +
    $"\tetc = {rubles / converter.Btc:0.00000}\n" +
    $"\teth = {rubles / converter.Eth:0.00000}\n" +
    $"\tbnb = {rubles / converter.Bnb:0.00000}");

Console.WriteLine($"{btc} Btc = {btc * converter.Btc} рублей");
