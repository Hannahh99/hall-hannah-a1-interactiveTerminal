using System.Security.AccessControl;

//Ask for player name, remember it
Console.Write("Enter Name: ");
string playerName = Console.ReadLine();
Console.WriteLine();

//Print context story
Console.WriteLine("  The fall fair is an event the town of Autumnshield looks forward to annually. Your parents bring you along");
Console.WriteLine(" with them and tell you to go have fun while they get something to eat. This year you're on your own it seems.");
Console.WriteLine(" They give you some money to go purchase tickets and they head off. You approach the ticket booth.");
Console.WriteLine();
Console.WriteLine(" How many tickets would you like to purchase?");
Console.WriteLine();

//Player enters ticket amount
int playerTickets = int.Parse(Console.ReadLine());
Console.WriteLine();

//Activity Costs
    int ferrisWheelCost = 1;
    int bumperCarCost = 1;
    int gameCost = 1;
//declare game prize
bool ringTossPrize = false;

//Player is informed of activity options
Console.WriteLine("  Nice, time to 'have fun.' As you look around the fairgrounds you spot several rides which catch your interest.");
Console.WriteLine(" Where do you want to go first?");
Console.WriteLine("(Enter number to proceed)");
Console.WriteLine($" 1. The Ferris wheel (cost: {ferrisWheelCost} Tickets)");
Console.WriteLine($" 2. The bumper cars (cost: {bumperCarCost} Tickets)");
Console.WriteLine($" 3. Play a game (cost: {gameCost} Tickets)");
Console.WriteLine();

//Player enters response/chooses activity
Console.Write("Activity: ");
int playerActivity = int.Parse(Console.ReadLine());
Console.WriteLine();

//Check if player has enough tickets
if (playerTickets >= 0)
{
    //Player proceeds to Ferris wheel route
    if (playerActivity == 1)
    {
        playerTickets -= ferrisWheelCost;
        //inform player of decision
        Console.WriteLine(" You head to the Ferris wheel.");
        Console.WriteLine($" You have {playerTickets} tickets left");
        //proceed story
        Console.WriteLine();
        Console.WriteLine("  After a few minutes of waiting in line for the Ferris wheel you manage to get on.");
        Console.WriteLine(" While you were waiting you noticed a tall man staring at you, though you decided it'd be best to ignore it.");
        Console.WriteLine(" It's cool to watch the sunset from this high over your town. However, when you look down,");
        Console.WriteLine(" you see that same stranger watching you from below.");
    }
    //Player proceeds to bumper car route
    else if (playerActivity == 2)
    {
        playerTickets -= bumperCarCost;
        //inform player of decision
        Console.WriteLine(" You head to the bumper cars");
        Console.WriteLine($" You have {playerTickets} tickets left");
        //proceed story
        Console.WriteLine();
        Console.WriteLine("  You rush over to the bumper cars, but on your way you accidentally stumble into someone.");
        Console.WriteLine(" The tall man glares down at you and tells you to 'watch yourself.' You brush off the encounter and keep moving.");
        Console.WriteLine(" You might have broken your back on the bumper cars but it was worth it, you tell yourself.");
    }
    //Player proceeds to game route
    else if (playerActivity == 3)
    {
        playerTickets -= gameCost;
        //inform player of decision
        Console.WriteLine(" You go to play a game");
        Console.WriteLine($" You have {playerTickets} tickets left");
        //proceed story
        Console.WriteLine();
        Console.WriteLine("  You approach one of the carnival games and a man behind the counter hands you some rings. Ring toss it is then.");
        Console.WriteLine(" You give it your best shot and aim to the...");
        Console.WriteLine("(Left/Right)");
        string ringTossOutcome = Console.ReadLine();
        //player wins ring toss
        if (ringTossOutcome == "Left")
        {
            Console.WriteLine();
            Console.WriteLine("  You toss the ring, angling it to go left.");
            Console.WriteLine(" 'Nice toss kiddo.' Says the man behind the counter as he hands you a prize. A little stuffed rabbit.");
            //add prize to inventory
            ringTossPrize = true;
            Console.WriteLine(" You take your prize but as you turn to leave you notice a tall figure watching you in the distance.");
        }
        //player loses ring toss
        else
        {
            Console.WriteLine();
            Console.WriteLine("  You toss the ring, aiming for a bit of a right curve... That backfired.");
            Console.WriteLine(" You missed your target and the man behind the counter gives you a condescending look that says 'tough luck, kid.'");
            Console.WriteLine(" Better luck next time, you suppose. As you turn to leave you notice a tall figure watching you in the distance...");
        }
    }
    //Player entered an invalid option
    else
    {
        Console.WriteLine(" You decide you would rather not partake in the festivities and wait by the ticket booth for your parents to return.");
    }
}
else
{
    Console.WriteLine(" You don't have enough tickets...");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("  Well that was fun... You make your way back to the ticket booth to see if your parents have returned yet.");
Console.WriteLine(" On your way, you notice that stranger from before. They seem to be following you...");
Console.WriteLine(" Upon this realization, you also notice how they appear to be approaching you. Walking groggily in your direction.");
Console.WriteLine($" Someone has had too much apple cider... While these thoughts run through your head, they call out to you, '{playerName}!'");
Console.WriteLine($" They know you? A friend of your parents maybe...? 'C'mon {playerName}, your parents have been looking for you.'");
Console.WriteLine(" They gesture you to follow... What do you want to do?");
Console.WriteLine("(Enter number to proceed)");
Console.WriteLine(" 1. Follow them");
Console.WriteLine(" 2. Refuse to go");
Console.WriteLine();
int playerChoice_2 = int.Parse(Console.ReadLine());
Console.WriteLine();

//player follows stranger --> game over: Ending 1
if (playerChoice_2 == 1)
{
    Console.WriteLine("  You follow the stranger. As you follow, you notice everything around you darken. They take you to a back alleyway");
    Console.WriteLine(" leading out of the fair, telling you, 'your parents are just down this way with their car, ready to drive you home.'");
    Console.WriteLine(" Unease begins to trickle in but you decide to keep following... you reach the end of the path,");
    Console.WriteLine(" but your parent's car is nowhere to be seen. The only vehicle in sight is a white van.");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("  It has been three months since you were last seen, at the fall fair. Winter settles in and the hope of finding you");
    Console.WriteLine(" alive has long since vanished. Your parents cooperate with authorities and do everything in their power");
    Console.WriteLine(" to track you down, but there is not a single trace to be found. Nobody even witnessed you leaving.");
    Console.WriteLine("Ending 1/5");
}
//player refuses to follow
else if (playerChoice_2 == 2)
{
    Console.WriteLine("  Your parents told you they would come collect you later, and this man is certainly not one of them.");
    Console.WriteLine(" 'Don't worry kid, I ain't gonna hurt ya. Just follow me. I've even got some treats for ya.' This stranger doesn't seem");
    Console.WriteLine(" to be taking 'no' for an answer. They reach out to grab you by the arm. Time to think fast.");
    Console.WriteLine(" Do you...");
    Console.WriteLine(" 1. Call out for help");
    Console.WriteLine(" 2. Push them over... They seem tipsy enough");
    //if player collected prize, add option
    if (ringTossPrize == true)
    {
        Console.WriteLine(" 3. Throw prize as distraction");
    }
    Console.WriteLine();
    int playerChoice_3 = int.Parse(Console.ReadLine());
    Console.WriteLine();

    //player calls for help --> game over: Ending 2
    if (playerChoice_3 == 1)
    {
        Console.WriteLine("  You shout for help, the noise gets drowned out by the screams of other festival goers having fun. However, one nearby");
        Console.WriteLine(" group of people turn their attention to you, when they see the strange man grabbing you they rush over to assist,");
        Console.WriteLine(" pulling them away and holding them down.");
        Console.WriteLine();
        Console.WriteLine(" You got lucky. Lucky they didn't think it to be a familial dispute. Lucky they interfered.");
        Console.WriteLine(" The group calls security over and they apprehend the stranger. They then wait with you for your parents to return.");
        Console.WriteLine("Ending 2/5");
    }
    //player shoves the stranger --> game over: Ending 3
    else if (playerChoice_3 == 2)
    {
        Console.WriteLine("  You push them and they fall over, onto their back. This gives you a chance to get away and you take it, rushing off.");
        Console.WriteLine(" You run up to a security guard and inform them of the situation. But by the time you bring them back to where you left");
        Console.WriteLine(" the stranger, they are gone. The guard seems to think you might have lied about the situation. But nevertheless,");
        Console.WriteLine(" they help you find your parents and you return home safely.");
        Console.WriteLine();
        Console.WriteLine(" They never caught the stranger.");
        Console.WriteLine("Ending 3/5");
    }
    //player throws prize --> game over: Ending 4
    else if (playerChoice_3 == 3)
    {
        Console.WriteLine("  You throw your prize at them and they flinch, you take this moment to turn and run away. You glance back to see the");
        Console.WriteLine(" stranger coming after you. Rushing over to one of the security guards patrolling the area, you inform them of the");
        Console.WriteLine(" situation. You point back to the stranger, who sees who you're speaking with and attempts to fade into the crowd.");
        Console.WriteLine(" The guard, however, matched the description you gave to the stranger and tackles them, pushing them to the ground");
        Console.WriteLine(" for apprehension.");
        Console.WriteLine();
        Console.WriteLine(" While everyone's focus is on the stranger you make your way to where you threw the prize. The plush is laying muddy on");
        Console.WriteLine(" the floor of the fairgrounds. You pick it up and brush it off... Then you return to the guards and wait for your");
        Console.WriteLine(" parents to return.");
        Console.WriteLine("Ending 4/5");
    }
    //player enters invalid response --> game over: Ending 5
    else
    {
        Console.WriteLine(" You freeze, unsure of what to do... The stranger grabs you and drags you off.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("  It has been three months since you were last seen, at the fall fair. Winter settles in and the hope of finding you");
        Console.WriteLine(" alive has long since vanished. Your parents cooperate with authorities and do everything in their power");
        Console.WriteLine(" to track you down, but there is not a single trace to be found. Nobody even witnessed you leaving.");
        Console.WriteLine();
        Console.WriteLine("... Maybe you should choose a valid option next time.");
        Console.WriteLine("Ending 5/5");
    }
}
//player enters invalid response --> game over: Ending 5
else
{
    Console.WriteLine(" You freeze, unsure of what to do... The stranger grabs you and drags you off.");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("  It has been three months since you were last seen, at the fall fair. Winter settles in and the hope of finding you");
    Console.WriteLine(" alive has long since vanished. Your parents cooperate with authorities and do everything in their power");
    Console.WriteLine(" to track you down, but there is not a single trace to be found. Nobody even witnessed you leaving.");
    Console.WriteLine();
    Console.WriteLine("... Maybe you should choose a valid option next time.");
    Console.WriteLine("Ending 5/5");
}