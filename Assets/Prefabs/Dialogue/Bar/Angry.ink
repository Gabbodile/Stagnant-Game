
#speaker:Angy Man #portrait:Barret

The fuck you want?!

* [just going through. Sorry] -> endConvo
* [Are you good?] -> IDontNeedYourPity
* [- puts up fists -] -> Fight

=== IDontNeedYourPity ===
What you think? Get out of here.

* [You dont need to be tough all the time] -> UnsolicitedAdvice
* [Want to talk about it?] -> what
* [I'll leave you to it] -> endConvo

=== UnsolicitedAdvice ===
Huh? What are you on about?

* [Want to talk about it?] -> NoOffence
* [Nevermind] -> endConvo

=== what ===
Whats in it for you?

* [You dont have to tell me] -> NoOffence
* [I dunno. Boredom] -> Boredom
* [Just thought it would be nice] -> ImNiceGuy

=== NoOffence ===
yeah, no offence but it'd be real fucking weird to just tell a stranger all my problems. 

Fucking creepy kinda.

* [I dont mean to be creepy] -> why
* [You're right. Just thought to check] -> ImNiceGuy

=== Boredom ===
You think this is some form of entertainment?

I could fuck you up you know?

* [Yeah, I know] -> ImNiceGuy
* [I'm sure you could] -> why
* [nah.]
    The fuck you mean 'nah'? You dont think I could?! -> DONE

=== ImNiceGuy ===
...

You really would come up to some random guy like me just to be nice?

Fucking weirdo. 

But I appreciate it, dude.

->DONE 
=== why===
then why tf are you here?

* [Just thought it would be nice] -> ImNiceGuy
* [I actually dont know] 
    Then scram. I dont want you here. -> DONE
* [Conversation.] -> ImNiceGuy

=== Fight ===
Bro what the fuck?

You're looking for a fight?

* [Sorry, my mistake] -> endConvo
* [- Throw a punch -] -> buhBye

=== buhBye ===
Big mistake little man.

-> DONE

//go to car ride

=== endConvo ===
Hmph.
    
Thats what I fucking thought. Beat it.
-> DONE