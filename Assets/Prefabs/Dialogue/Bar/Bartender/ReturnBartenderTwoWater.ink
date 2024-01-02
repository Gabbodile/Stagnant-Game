Hey, welcome back! What'll it be this time sir?  #speaker:Bartender #portrait:Bartender

 * [Hey! Another glass of water please] ->GiveThreeWater
 * [I'll take a shot of whisky please] ->GiveWWThenAlcohol
 * [Actually, I'm not that thirsty] ->MattLeaveAfterTwoWater
 
 === GiveWWThenAlcohol ===
 Of course!
There you are.
- He hands you a shot of whisky -

* [Thanks *Drink*] ->TalkAfterTwoWaterOneAlcohol

=== TalkAfterTwoWaterOneAlcohol ===
...
You're looking a little uncomfortable there, did you need the bathroom? 
It's just on the right.

* [Yeah, thanks] ->NoProblemMattGoBathroom

=== NoProblemMattGoBathroom ===
No problem

* [*NEXT*] ->NoProblemMattGoBathroomContinued

=== NoProblemMattGoBathroomContinued ===
#speaker:Matt #portrait:Matt
Hmm Bathroom, Bathroom...

->DONE 
//Matt leaves the bartender after having two water then one alcohol
 
 === GiveThreeWater ===
 Sure thing!
 Here you are.
- He hands you another glass of water -

* [*Drink*] ->TalkAboutBathroom 

=== TalkAboutBathroom ===
...
You look a little uncomfortable there, bathroom is just on your right if you need it.

* [Thanks, I was just about to ask actually] ->LeaveAfterThreeWater

=== LeaveAfterThreeWater ===
Heh no worries sir, have a good one.

* [*NEXT*] ->MattThinkBathroomNormal

=== MattThinkBathroomNormal ===
#speaker:Matt #portrait:Matt
Bathroom...Bathroom...

->DONE
//Matt leaves bartender after three water and looks for bathroom, can't talk to anyone without going to bathroom now

 === MattLeaveAfterTwoWater ===
 No worries, have a good one.

* [Thanks, you too] ->DONE
//Matt leaves the bartender after having two water in his system




