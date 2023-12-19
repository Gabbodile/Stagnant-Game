
#speaker:... #portrait:Barret

The fuck are you looking at?!

* [Nothing, sorry. Just passing through.] -> endConvo
* [Are you alright?] -> IDontNeedYourPity
* [Obviously you, asshole.] -> Fight

=== IDontNeedYourPity ===
What do you think? Get out of here.

* [Did you...want to talk about it?] -> what
* [I'll leave you to it] -> endConvo

=== what ===
- Scoffs - Talk about it? What are you, my therapist? What's in it for you?

* [Nothing, sorry, I just thought I'd ask.] -> NoOffence
* [I dunno. Boredom] -> Boredom
* [Sorry, it's none of my business, I'll let you be.] -> PolitelyEndConvo

=== PolitelyEndConvo ===
 Whatever.
 
 ->DONE

//go to bar main shot

=== NoOffence ===
Heh...yeah no offence but it's a little weird to just spill my guts out to some stranger. 

Sticking your nose in someone else's business instead of just minding your own...

* [Sorry I didn't mean to pry.] -> why
* [Yeah sorry, I just thought it would be nice to check.] -> ImNiceGuy

=== Boredom ===
You think this is some kind of entertainment?

I could fuck you up you know?

* [I'm sure you could] -> why
* [Nah.]
    The fuck you mean 'nah'? You don't think I could?! -> Fight

=== ImNiceGuy ===
...

You really would come up to some random guy like me...just to be "nice"?

Heh you must be all kinds of crazy, man. 
- Laughs to himself -
Damn, I haven't laughed like this in a long time...you got a name?

* [It's Matt] -> HeThank 


=== HeThank ===
 You're a strange one Matt...Thanks.
 
 * [No problem...uhhh] ->Introduce
 
 === Introduce ===
 #speaker:Barret #portrait:Barret
 Barret, the name's Barret.
 
 * [*Nod head and leave*] ->DONE //go to bar main shot
 
 * [I'm glad I could help, will you be alright?] ->GladToHelp
 
 === GladToHelp ===
 Yeah, just things not going as planned, I'll be alright here, thanks.
 
 * [*Nod head and leave*] ->DONE

//go to bar main shot

=== why===
Then why are you still in here?

* [Because you look like you could do with having someone to talk to.] -> ButWhy
* [I actually don't know] 
    Then scram. I don't want you buzzing about in my ear. -> DONE

 === ButWhy ===
 And why would you wanna do that? Cause it's the "Nice" thing to do?
 
 * [Well...Yeah.] ->ImNiceGuy
 * [Yes actually.] ->ImNiceGuy

=== Fight ===
You looking for a fucking fight punk!?


* [Sorry, nevermind.] -> endConvo
* [I don't know, are you!? *Throw a punch*] -> buhBye

=== buhBye === 
- Laughs- 
Big mistake buddy.
 - punch -
 
 //go to bar main shot
-> PunchedThroughBathroomDoor

 === PunchedThroughBathroomDoor ===
 #speaker:Dillon #portrait:Laid_Back
 ...
 Wholly shit!
 Matt are you okay!?
 
 * [*Groan*] ->AngryBarGuyYell
 
 === AngryBarGuyYell ===
 #speaker:... #Portrait:Barret
 ...
 That's for not minding your damn fucking business punk!
 
 ->DillonDefend
 
 === DillonDefend ===
 #speaker:Dillon #portrait:Laid_Back
 ...
 Hey! 
 Look I don't know what my friend did to you in there but please go easy on him, he's not himself. I'm sure he didn't really mean to bother you.
 
 ->GrumblingAngryBarGuy
 
 === GrumblingAngryBarGuy ===
#speaker:... #portrait:Barret
 ...
 - He glares at you -
 
 * [*NEXT*] ->SayNothing
 
 === SayNothing ===
 #speaker:Dillon #portrait:Laid_Back
 ...
 I sincerely apologise on his behalf, it won't happen again.
 
 ->BarretGlareAtDillon
 
 === BarretGlareAtDillon ===
 #speaker:... #portrait:Barret
 ...
 Whatever
 - He leaves -
 
 ->DillonSighs
 
 === DillonSighs ===
 #speaker:Dillon #portrait:Laid_Back
 ...
 - Sigh -
 Are you okay? What were you thinking?
 
 * [I don't know...] ->DontKnowDillon
 
 === DontKnowDillon ===
 When I said to go meet new people to unwind, I didn't mean find some random and get in a fight...
 
 * [Sorry...] ->AtLeastYoureOkay
 * [He started it...] ->DontBeImmature
 
 === DontBeImmature ===
 Even if he did, you should've just backed off. 
 I'll admit, I'm impressed you were crazy enough to take on a dude that was built like a fridge but it'd be better if you didn't die ya know?
 
 * [Sorry...] ->AtLeastYoureOkay
 
 === AtLeastYoureOkay ===
 It's fine. What matters is that you're okay.
 Let's get you up
 
 * [*Stand up*] ->StoodUp
 
 === StoodUp ===
 There ya go, I'll help you to the car, don't worry, it's not too far away.
 
 * [Wait-Who was...that?] ->DONE 
 //In bar main shot. Vanessa smudge there.

=== endConvo ===
Hmph.
    
Thats what I fucking thought. Beat it.
-> DONE
//go to bar main shot
