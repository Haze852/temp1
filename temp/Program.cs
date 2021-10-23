using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playerRoll = true;
            bool comRoll = true;
            int comSUM, playerSUM, dice1, dice2, dice3, dice4, comDice1, comDice2, comDice3, comDice4;
            comSUM = 0;
            playerSUM = 0;
            Random r = new Random();

            //com roll dice
            while (comRoll == true)
            {
                comDice1 = r.Next(1, 7);
                comDice2 = r.Next(1, 7);
                comDice3 = r.Next(1, 7);
                comDice4 = r.Next(1, 7);
                Console.WriteLine($"Dealer dice:{comDice1}, {comDice2}, {comDice3}, {comDice4}");

                //computer 4顆相同 WIN
                if (comDice1 == comDice2 && comDice2 == comDice3 && comDice3 == comDice4)
                {
                    Console.WriteLine("一色！YOU LOSE!!!");
                    break;
                }

                //4顆都不同 重擲
                if (comDice1 != comDice2 && comDice2 != comDice3 && comDice3 != comDice4)
                {
                    Console.WriteLine("無點,重擲");
                    continue;
                }

                //3顆相同 重擲
                if (comDice1 == comDice2 && comDice2 == comDice3)
                {
                    Console.WriteLine("重擲");
                    continue;
                }
                if (comDice2 == comDice3 && comDice3 == comDice4)
                {
                    Console.WriteLine("重擲");
                    continue;
                }
                if (comDice3 == comDice4 && comDice4 == comDice1)
                {
                    Console.WriteLine("重擲");
                    continue;
                }

                //2顆點數相同 扣除2顆點數相同的骰子 合計點數
                if (comDice1 == comDice2)
                {
                    comSUM = comDice3 + comDice4;
                    Console.WriteLine($"Dealer point:{comSUM}");
                    break;
                }
                if (comDice2 == comDice3)
                {
                    comSUM = comDice1 + comDice4;
                    Console.WriteLine($"Dealer point:{comSUM}");
                    break;
                }
                if (comDice3 == comDice4)
                {
                    comSUM = comDice1 + comDice2;
                    Console.WriteLine($"Dealer point:{comSUM}");
                    break;
                }
                if (comDice4 == comDice1)
                {
                    comSUM = comDice2 + comDice3;
                    Console.WriteLine($"Dealer point:{comSUM}");
                    break;
                }

                //2組點數相同 取較大組合計點數
                if (comDice1 == comDice2 && comDice3 == comDice4)
                {
                    if (comDice1 > comDice3)
                    {
                        comSUM = comDice1 * 2;
                        Console.WriteLine($"Dealer point:{comSUM}");
                        break;
                    }
                    if (comDice3 > comDice1)
                    {
                        comSUM = comDice3 * 2;
                        Console.WriteLine($"Dealer point:{comSUM}");
                        break;
                    }
                }

                if (comDice2 == comDice3 && comDice1 == comDice4)
                {
                    if (comDice2 > comDice1)
                    {
                        comSUM = comDice2 * 2;
                        Console.WriteLine($"Dealer point:{comSUM}");
                        break;
                    }
                    if (comDice1 > comDice2)
                    {
                        comSUM = comDice1 * 2;
                        Console.WriteLine($"Dealer point:{comSUM}");
                        break;
                    }
                }

                if (comDice1 == comDice3 && comDice2 == comDice4)
                {
                    if (comDice1 > comDice2)
                    {
                        comSUM = comDice1 * 2;
                        Console.WriteLine($"Dealer point:{comSUM}");
                        break;
                    }
                    if (comDice2 > comDice1)
                    {
                        comSUM = comDice2 * 2;
                        Console.WriteLine($"Dealer point:{comSUM}");
                        break;
                    }
                }
            }


            //player roll dice 
            while (playerRoll == true)
            {
                dice1 = r.Next(1, 7);
                dice2 = r.Next(1, 7);
                dice3 = r.Next(1, 7);
                dice4 = r.Next(1, 7);
                Console.WriteLine($"Your dice:{dice1}, {dice2}, {dice3}, {dice4}");

                //4顆相同 WIN
                if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
                {
                    playerRoll = false;
                    Console.WriteLine("一色！YOU WIN!!!");
                }

                //4顆都不同 重擲
                if (dice1 != dice2 && dice2 != dice3 && dice3 != dice4)
                {
                    Console.WriteLine("無點,重擲");
                    continue;
                }

                //3顆相同 重擲
                if (dice1 == dice2 && dice2 == dice3)
                {
                    Console.WriteLine("重擲");
                    continue;
                }
                if (dice2 == dice3 && dice3 == dice4)
                {
                    Console.WriteLine("重擲");
                    continue;
                }
                if (dice3 == dice4 && dice4 == dice1)
                {
                    Console.WriteLine("重擲");
                    continue;
                }


                //2顆點數相同 扣除2顆點數相同的骰子 合計點數
                if (dice1==dice2)
                {
                    playerSUM = dice3 + dice4;
                    Console.WriteLine($"Your point:{playerSUM}");
                    break;
                }
                if (dice2 == dice3)
                {
                    playerSUM = dice1 + dice4;
                    Console.WriteLine($"Your point:{playerSUM}");
                    break;
                }
                if (dice3 == dice4)
                {
                    playerSUM = dice1 + dice2;
                    Console.WriteLine($"Your point:{playerSUM}");
                    break;
                }
                if (dice4 == dice1)
                {
                    playerSUM = dice2 + dice3;
                    Console.WriteLine($"Your point:{playerSUM}");
                    break;
                }

                //2組點數相同 取較大組合計點數
                if (dice1 == dice2 && dice3 == dice4)
                {
                    if(dice1 > dice3)
                    {
                        playerSUM = dice1 * 2;
                        Console.WriteLine($"Your point:{playerSUM}");
                        break;
                    }
                    if (dice3 > dice1)
                    {
                        playerSUM = dice3 * 2;
                        Console.WriteLine($"Your point:{playerSUM}");
                        break;
                    }
                }

                if (dice2 == dice3 && dice1 == dice4)
                {
                    if (dice2 > dice1)
                    {
                        playerSUM = dice2 * 2;
                        Console.WriteLine($"Your point:{playerSUM}");
                        break;
                    }
                    if (dice1 > dice2)
                    {
                        playerSUM = dice1 * 2;
                        Console.WriteLine($"Your point:{playerSUM}");
                        break;
                    }
                }

                if (dice1 == dice3 && dice2 == dice4)
                {
                    if (dice1 > dice2)
                    {
                        playerSUM = dice1 * 2;
                        Console.WriteLine($"Your point:{playerSUM}");
                        break;
                    }
                    if (dice2 > dice1)
                    {
                        playerSUM = dice2 * 2;
                        Console.WriteLine($"Your point:{playerSUM}");
                        break;
                    }
                }
            }

            if (comSUM > playerSUM)
            {
             Console.WriteLine("YOU LOSE!!!");
            }
            else if (playerSUM > comSUM)
            {
                Console.WriteLine("YOU WIN!!!");
            }
            else if (playerSUM == comSUM)
            {
                Console.WriteLine("DRAW!!!");
            }
        }
    }
}