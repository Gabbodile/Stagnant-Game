Hey, welcome back! What'll it be this time sir?  #speaker:Bartender #portrait:Bartender

* [I'll have another glass of water please] ->GiveWAW
* [A shot of whiskey for me, thanks] ->GiveWAA
* [Actually, I'm alright for drinks, thanks] ->MattLeaveOneWaterAndOneAlcohol

=== GiveWAW ===
Sure!
There you are.
- He hands you another glass of water -

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
//Matt leaves the bartender after having two water and one alcohol

=== GiveWAA ===
Yup, here you are.
- He hands you a shot of whisky -

* [*Drink*] ->HeDrankWAA

=== HeDrankWAA ===
...Are you alright there? 
You're looking a little uneasy, did you need the bathroom?

* [Uhmm...Probsably...] ->HeDrankWAAContinued

=== HeDrankWAAContinued ===
It's just on your right.
Might be good to rinse your face with some cold water while you're there.

* [Thankshh] ->MattThinkBathroomTipsyAfterWAA

=== MattThinkBathroomTipsyAfterWAA ===
#speaker:Matt #portrait:Matt
Uhh Bathroomss...man, I gotsta go soons...

->DONE
//Matt leaves the bartender after having one water and two alcohol, he is tipsy

=== MattLeaveOneWaterAndOneAlcohol ===
No worries, have a good one.

* [Thanks, same to you] ->DONE 
//Matt leaves the bartender with one alcohol and one water in his system

