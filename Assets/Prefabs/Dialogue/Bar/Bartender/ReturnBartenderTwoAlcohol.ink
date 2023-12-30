Hey welcome back! #speaker:Bartender #portrait:Bartender
A-Are...you alright sir? Can I get you some water?

* [Yessh...that soundes good...] ->TwoAlcoholOfferWaterCathy
* [Nope thanksh you...jusst a shot of whisky pleashh] ->Concern
* [Nahhh...I'm jushht looking arounds...] ->MattLeaveTipsy 

=== TwoAlcoholOfferWaterCathy ===
Here you are.
- He hands you a glass of water -

* [*Drink*] ->MattDrankAAW 

=== MattDrankAAW ===
...You're looking a little uncomfortable...
Did you need the bathroom? It's just on your right.

* [Ohh Tankss...] ->MattDrankAAWContinued

=== MattDrankAAWContinued ===
You're welcome sir...

* [*NEXT*] ->MattThinkBathroomTipsy

=== MattThinkBathroomTipsy ===
#speaker:Matt #portrait:Matt
Uhh Bathroomss...man, I gotsta go soons...

->DONE
//Matt leaves the bartender after having two alcohol and one water, he is tipsy

=== MattLeaveTipsy ===
Uhh okay...? 
S-Sir, please be mindful of your surroundings...

* [Yupss, I've got this...] ->BartenderConcern
* [Aye Aye Cappin'!] ->BartenderConcern

=== BartenderConcern ===
- He watches you leave with great concern -

->DONE 
//Matt leaves the bartender with two alcohol in his system

=== Concern ===
Sir? I don't think that would be a good idea...

* [And I says itshh a great idea...I really needs one] ->LectureMatt
* [Hmmm...Maybes I has waaterr insteads?] ->GoodIdea

=== LectureMatt ===
Sir you really don't, trust me...
I've seen my fair share of poor men and women that come to drink their lives away and the result is never pretty...

* [*NEXT*] ->LectureMattContinued

=== LectureMattContinued ===
I don't know what exactly you're going through but I can guarantee you that drinking away your pain until you black out won't fix it.
You need to face your problems head on. 

* [I don't wants a lecture. Jusht one lasht drink...please...?] ->FineGiveUp
* [...I...Sorry...I thinks I'll jusst go washh up] ->AskBathroom

=== FineGiveUp ===
- Sigh - 
Alright, fine...
There's no use in trying to help someone who doesn't want it.
...
- He reluctantly hands you a shot of whisky -

* [*Drink up* ] ->HeDrankTooMuch

=== HeDrankTooMuch ===
#speaker:Matt #portrait:Matt
...!?
I... - retches -
I don't feel so... - Vomits -

* [*NEXT*] ->HeDrankTooMuchContinued

=== HeDrankTooMuchContinued ===
#speaker:Dillon #portrait:Laid_Back
Matt!?
Hey are you okay bud?

* [No...] ->DillonHelpHimUp
* [*Groan*] ->DillonHelpHimUp

=== DillonHelpHimUp ===
Hey, take it easy, let me help you up there...
- He puts your arm over his shoulders and lifts you to your feet - 

* [*NEXT*] ->DillonSorry

=== DillonSorry ===
#speaker:Bartender #portrait:Bartender

Long time no see Dillon...

* [*NEXT*] ->DillonSorryContinued

=== DillonSorryContinued ===
#speaker:Dillon #portrait:Laid_Back

Hey man, yeah...
Uhh...really sorry about my friend here, he's not normally like this...
I'll take his drinks under my TAB

* [*NEXT*] ->BartenderResponseToDillon

=== BartenderResponseToDillon ===
#speaker:Bartender # portrait:Bartender

He's a deeply troubled one, that's for sure
It seems like he needs all the help he can get

* [*NEXT*] ->BarResponseContinued

=== BarResponseContinued ===
#speaker:Dillon #portrait:Laid_Back
Yeah, working on that...
Anyway, best be getting him home, again sorry about the trouble

* [*NEXT*] ->BarResponseContinuedAgain

=== BarResponseContinuedAgain ===
#speaker:Bartender #portrait:Bartender
- He nods his head - 

* [*Next*] ->BringMattToCar

=== BringMattToCar ===
#speaker:Dillon #portrait:Laid_Back
- Sigh -
What am I gonna do with ya bud?
Let's get you to the car

->DONE
//Matt has been taken to the car to be driven home, he is drunk 

=== AskBathroom ===
- He nods his head -
Bathroom is on your right

* [*NEXT*] ->MattLeaveAfterTwoAlcohol

=== MattLeaveAfterTwoAlcohol ===
#speaker:Matt #portrait:Matt
Hmmm...I really sooden't be drinking so mush...
Wheresh *Hic* bathroom again...?

->DONE
//Matt leaves bartender with two alcohol in his system and is tipsy, all but bathroom is locked

=== GoodIdea ===
Yes, I can help you with that.
Here you are sir.
- He hands you a glass of water - 

* [Tankss *Drink*] ->MattDrankAAW
