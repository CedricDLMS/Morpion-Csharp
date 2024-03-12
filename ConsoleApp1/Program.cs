// See https://aka.ms/new-console-template for more information


string[,] morpionDisplay ={    { " ", " ", " " },    { " ", " ", " " },    { " ", " ", " " }};int[,] morpionInt = {    { 0, 0, 0 },    { 0, 0, 0 },    { 0, 0, 0 }};void actualiserDisplay(){    for (int i = 0; i <= 2; i++)    {        void actualiserLigne(int x)        {            if (morpionInt[x,i] == 1)            {                morpionDisplay[x, i] = "X";            }            if (morpionInt[x, i] == 2)            {                morpionDisplay[x, i] = "O";            }        }        actualiserLigne(0);        actualiserLigne(1);        actualiserLigne(2);    }}void afficherDisplay(){    void afficherLigne(int x)    {        for (int i = 0;i <= 2; i++)        {            actualiserDisplay();            if(i==1){ Console.Write("| " + morpionDisplay[x,i] + " |" ); } else
            {
                Console.Write(" " + morpionDisplay[x, i]+ " ");
            }                    }    }    afficherLigne(0);    Console.WriteLine();
    Console.WriteLine("---|---|---");
    afficherLigne(1);
    Console.WriteLine();
    Console.WriteLine("---|---|---");
    afficherLigne(2);
    Console.WriteLine();
    
}

int demanderPosition(int joueurCours)
{
    string positionS = "";
    int positionN = 0;
    if (joueurCours == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("-------------------------------------JOUEUR 1 JOUE-------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.ResetColor();
    }
    else if(joueurCours == 2)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("-------------------------------------JOUEUR 2 JOUE-------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.ResetColor();
    }
    Console.WriteLine("Veuillez saisir le numéro que vous souhaitez jouer en suivant le tableau ci dessous :");
    Console.WriteLine(" 1  2  3  \n 4  5  6  \n 7  8  9  ");
    positionS = Console.ReadLine();
    positionN = Int32.Parse(positionS);
    return positionN;
}

void changerPion(int joueurEnCours,int place)
{
    
    if (joueurEnCours == 1)
    {
        if(place <= 3)
        {
            morpionInt[0,place-1] = 1;
        }
        if (place >= 4 && place <= 6)
        {
            morpionInt[1, (place-4)] = 1;
        }
        if (place >= 7 && place <= 9)
        {
            morpionInt[2, (place-7)] = 1;
        }
    }
    else if (joueurEnCours == 2)
    {
        if (place <= 3)
        {
            morpionInt[0, place-1] = 2;
        }
        if (place >= 4 && place <= 6)
        {
            morpionInt[1, (place-4)] = 2;
        }
        if (place >= 7 && place <= 9)
        {
            morpionInt[2, (place-7)] = 2;
        }
    }
}

bool checkVictoireHorizontale(int joueur)
{
    bool checkLigne(int x,int joueurChoisis)
    {
        //if(morpionInt[x,1]*morpionInt[x, 2]* morpionInt[x, 0] == 1)
        //{
        //    return true;
        //}
        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
        //{
        //    return true;
        //}
        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
        //{
        //    return true;
        //}
        bool morpionVictoireX = ((morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0]) == 1);
        bool morpionVictoireY = ((morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0]) == 8);
        if(joueurChoisis == 1)
        {
            if (morpionVictoireX) 
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
        if (joueurChoisis == 2)
        {
            if (morpionVictoireY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;


    }
    if (checkLigne(0, joueur))
    {
        return true;
    }
    if (checkLigne(1, joueur))
    {
        return true;
    }
    if (checkLigne(2, joueur))
    {
        return true;
    }
    else {
        return false; 
    }
}

bool checkVictoireVerticale(int joueur)
{
    bool checkLigne(int x, int joueurChoisis)
    {
        //if(morpionInt[x,1]*morpionInt[x, 2]* morpionInt[x, 0] == 1)
        //{
        //    return true;
        //}
        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
        //{
        //    return true;
        //}
        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
        //{
        //    return true;
        //}
        bool morpionVictoireX = (morpionInt[0, x] * morpionInt[1, x] * morpionInt[2, x] == 1);
        bool morpionVictoireY = (morpionInt[0, x] * morpionInt[1, x] * morpionInt[2, x] == 8);
        if (joueurChoisis == 1)
        {
            if (morpionVictoireX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (joueurChoisis == 2)
        {
            if (morpionVictoireY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;


    }
    if (checkLigne(0, joueur))
    {        
        return true;
    }
    if (checkLigne(1, joueur))
    {       
        return true;
    }
    if (checkLigne(2, joueur))
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool checkVictoireDiagonale(int joueur)
{
    bool checkLigne(int x, int joueurChoisis)
    {
        //if(morpionInt[x,1]*morpionInt[x, 2]* morpionInt[x, 0] == 1)
        //{
        //    return true;
        //}
        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
        //{
        //    return true;
        //}
        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
        //{
        //    return true;
        //}
        bool morpionVictoireX = (morpionInt[0, 0] * morpionInt[1, 1] * morpionInt[2, 2] == 1 || morpionInt[0, 2] * morpionInt[1, 1] * morpionInt[2, 0] == 1);
        bool morpionVictoireY = (morpionInt[0, 0] * morpionInt[1, 1] * morpionInt[2, 2] == 8 || morpionInt[0, 2] * morpionInt[1, 1] * morpionInt[2, 0] == 8);
        if (joueurChoisis == 1)
        {
            if (morpionVictoireX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (joueurChoisis == 2)
        {
            if (morpionVictoireY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;


    }
    if (checkLigne(0, joueur))
    {
        return true;
    }
    if (checkLigne(1, joueur))
    {
        return true;
    }
    if (checkLigne(2, joueur))
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool checkVictoire(int joueur)
{
    if (checkVictoireDiagonale(joueur) == true || checkVictoireHorizontale(joueur) == true || checkVictoireVerticale(joueur) == true)
    {
        return true;
    }
    else { return false; }
}

int tourCounter = 1;

void tour()
{
    for (int i = 1; i < 10; i++)
    {
        actualiserDisplay();
        if (i%2 == 0)
        {
            Console.Clear();
            actualiserDisplay();
            afficherDisplay();
            changerPion(2,demanderPosition(2));
            actualiserDisplay();
            tourCounter++;
            if (checkVictoire(2))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------JOUEUR 2 GAGNE-----------------------------------");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.ResetColor();
                break;
            }
            else
            {
                continue;
            }
        }
        else
        {
            Console.Clear();
            actualiserDisplay();
            afficherDisplay();
            changerPion(1, demanderPosition(1));
            actualiserDisplay();
            tourCounter++;
            if (checkVictoire(1))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------JOUEUR 1 GAGNE-----------------------------------");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.ResetColor();
                break;
            }
            else
            {
                continue;
            }
        }
    }}tour();Console.WriteLine("Appuyez sur entrée pour fermer...");Console.ReadLine();