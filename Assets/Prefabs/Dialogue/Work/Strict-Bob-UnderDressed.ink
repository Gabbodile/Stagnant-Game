#speaker:Bob #portrait:Strict
Morning Matt - He glances at your appearance -
...
Your presentation is important you know?

* [I'm wearing clothes, that should be enough shouldn't it?] ->NotExcuse
* [I know, I couldn't find my uniform this morning] ->KindOfExcuse

 === KindOfExcuse ===
 Being disorganised won't end well with the boss, you know that right?
 You should prioritise the more important things you need to do in the day first.
 
 * [I know] ->NotTalkingAboutThat
 
 === NotExcuse ===
 Matt, the last thing we need is more people following Dillon's fashion advice. 
 
 * [Heh good one] ->ImSerious
 * [*Glance at Dillon*] ->GlanceAtDillon
 * [*Say nothing*] ->NotTalkingAboutThatAlteration
 
 === ImSerious ===
 I'm not joking.
 
 *[*Stare blankly at Bob*] ->Sigh
 *[Sorry...] ->NotTalkingAboutThatAlteration
 
 === GlanceAtDillon ===
 #speaker:Dillon #portrait:Laid_Back
 Hey bud!
 
 * [* Wave at Dillon*] ->Sigh 
 * [*Look back to Bob*] ->NotTalkingAboutThatAlteration
 
 === Sigh ===
 #speaker:Bob #portrait:Strict
 Hm...Anyway, your clothes aren't the only thing I'm referring to. You're slouching and moping about.
 ...
 You still haven't gotten over what happened yet have you?
 
 * [Not really...] ->ItsBeenAges
 * [Yes I have actually] ->DoesntLookLikeIt
 * [Why do you even care?] ->Pathetic 
 
 === NotTalkingAboutThatAlteration ===
 Reguardless, your clothes aren't the only thing I'm referring to. You're slouching and moping about.
 ...
 You still haven't gotten over what happened yet have you?
 
 * [Not really...] ->ItsBeenAges
 * [Yes I have actually] ->DoesntLookLikeIt
 * [Why do you even care?] ->Pathetic 

=== NotTalkingAboutThat ===
 Reguardless, your clothes aren't the only thing I'm referring to. You're slouching and moping about.
 ...
 You're still stuck on what happened aren't you?
 
* [No...] ->DoesntLookLikeIt
* [I'm still working through things...] ->Typical
* [Why do you even care?] ->Pathetic

=== ItsBeenAges ===
Mathew it's been how long now? The way you betrayed Vanessa was cowardly but even she was able to move on from what happened. 
You need to get your act together and actually TRY to move forward.

* [I know. I'm trying...] ->TryHarder
* [*Look away*] ->DoItForYourself

 === DoItForYourself ===
 Do it for yourself if not for her.
 I'll be seeing you Matt.
 
 * [*Nod head*] ->DONE
 * [See you...] ->DONE
 //Bob leaves breakroom

 === TryHarder ===
 From the looks of things, you need to try harder. You can start by making sure you get your work done and avoid slacking off. - He gestures to Dillon -
 I'll be seeing you Matt 
 
 * [See you...] ->DONE
 * [*Say nothing*] ->DONE 
 
 //Bob leaves breakroom

=== DoesntLookLikeIt ===
Mhm sure... 
Look it's obvious you're not over it, you can't deny that. What I don't understand is why you're still acting like she'll come back to you after what you did?
* [I...don't know...] ->DontKnow
* [*Look away*] ->DontKnow

 === DontKnow ===
 You're a grown man Matt, people can only be so patient with stubborn behaviour.
 You need to start getting your life together, staying stuck on what happened will get you nowhere. 
 Getting your work done without getting distracted would be a good start.
 I'll be going now.
 
 * [Bye...] ->DONE
 * [*Say nothing*] ->DONE
 
 //Bob leaves breakroom

=== Typical ===
Really Mathew? Still "working through things"? How long did you expect she was going to wait for you? Years? Decades? Everyone has their own lives to live, you included.
You need to learn to move on, the world won't wait for you, you know?
The sooner you realise that, the better off you'll be.

* [I know] ->ActLikeIt
* [I understand] ->ActLikeIt

 === ActLikeIt ===
 Good
 I'll be going now.
 
 * [Bye.] ->DONE
 
 //Bob leaves breakroom

=== Pathetic ===
Because it's depressing seeing you drag yourself around like you've given up in life, you can be more than that and you know it. 
I don't approve of you running away from Cyrus's daughter the way you did, they're family to me but I don't want to see you throwing your life away either. 

 * [*NEXT*] ->StartGettingLifeTogether
 
 === StartGettingLifeTogether ===
 You need to get your life together and stop living in the past.
 I'll be seeing you Matt, don't slack off, the boss won't take kindly to it if he catches you again.
 
 * [*Nod head*] ->DONE
 * [See you...] ->DONE
 
//Bob leaves breakroom

