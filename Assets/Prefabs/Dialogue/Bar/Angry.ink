
#speaker:Angy Man #portrait:Barret

The fuck are you looking at?!

* [Nothing, sorry. Just passing through.] -> endConvo
* [Are you alright?] -> IDontNeedYourPity
* [ Obviously you, asshole.] -> Fight

=== IDontNeedYourPity ===
What do you think? Get out of here.

* [Did you...want to talk about it?] -> what
* [I'll leave you to it] -> endConvo

=== what ===
- Scoffs - Talk about it? What are you, my therapist? What's in it for you?

* [Nothing, sorry, I just thought I'd ask.] -> NoOffence
* [I dunno. Boredom] -> Boredom
* [Nothing, just thought it would be nice.] -> ImNiceGuy
* [Sorry, it's none of my business, I'll let you be.] -> PolitelyEndConvo

=== PolitelyEndConvo ===
 Whatever.
 
 ->DONE

=== NoOffence ===
Heh...yeah no offence but it's a little weird to just spill my guts out to some stranger. 

Sticking your nose in someone else's business instead of just minding your own...

* [Sorry I didn't mean to pry.] -> why
* [Yeah sorry, I just thought I should check.] -> ImNiceGuy

=== Boredom ===
You think this is some kind of entertainment?

I could fuck you up you know?

* [I'm sure you could] -> why
* [Nah.]
    The fuck you mean 'nah'? You don't think I could?! -> Fight

=== ImNiceGuy ===
...

You really would come up to some random guy like me just to be nice?

Heh you must be all kinds of crazy, man. 
- Laughs to himself -
Damn, I haven't laughed like this in a long time...you got a name? Let me buy you a drink.

* [ Thanks, it's Matt ] -> HeBuyDrinkForU 
* [ It's Matt. I appreciate the offer but I'll be alright, I'm glad I could help out though, take care. ] -> LeaveAngryBar 

=== HeBuyDrinkForU ===
 Good to meet ya Matt, I'm Angry Bar Dude.

->DONE 

=== LeaveAngryBar ===
 No worries Matt, have a good one. 
 
 ->DONE 

=== why===
Then why are you still in here?

* [Because I want to help, it couldn't hurt to at least let me try right?] -> ImNiceGuy
* [I actually dont know] 
    Then scram. I don't want you buzzing about in my ear. -> DONE

=== Fight ===
You looking for a fucking fight punk!?


* [Sorry, nevermind.] -> endConvo
* [I don't know, are you!? - Throw a punch -] -> buhBye

=== buhBye === 
- Laughs- 
Big mistake buddy.
 - punch -
 
-> DONE

//go to car ride

=== endConvo ===
Hmph.
    
Thats what I fucking thought. Beat it.
-> DONE