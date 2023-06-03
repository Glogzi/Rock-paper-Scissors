namespace rock_paper_scissors;

class Program{
    static void Main(string[] args){
        //var settings
        Random rndm = new Random();
        String user;
        String pc;
        String[] RPS = {"r", "p", "s"};
        int randomIndex;
        while (true){//main loop
            Console.WriteLine("rock, paper or scissors? (r/p/s)");
            Console.Write(">");
            user = Console.ReadLine();
            //is input valid
            if(user != "r" && user != "p" && user != "s"){
                Console.WriteLine("Error, write r, p or s");
                continue;
            }
            Console.WriteLine(user);
            randomIndex = rndm.Next(0, RPS.Length);
            pc = RPS[randomIndex];
            //checks both side decision
            switch (user){
                case "p":
                    if(pc == "p"){
                        Console.WriteLine("you both used a paper, draw!");
                    }else if(pc == "r"){
                        Console.WriteLine("pc used rock, user wins!");
                    }else if(pc == "s"){
                        Console.WriteLine("pc used scissors, pc wins!");
                    }
                    break;
                case "s":
                    if(pc == "s"){
                        Console.WriteLine("you both used a scissors, draw!");
                    }else if(pc == "p"){
                        Console.WriteLine("pc used paper, user wins!");
                    }else if(pc == "r"){
                        Console.WriteLine("pc used rock, user wins!");
                    }
                break;
                case "r":
                    if(pc == "r"){
                        Console.WriteLine("you both used a rock, draw");
                    }else if(pc == "s"){
                        Console.WriteLine("pc used scissors, user wins!");
                    }else if(pc == "p"){
                        Console.WriteLine("pc used paper, pc wins!");
                    }
                break;
            }
            //starting over
            Console.WriteLine("press any key to start the game over");
            Console.ReadKey();
            Console.Beep();
        }
    }
}
