#speaker: Matt #portrait: Matt
Head down doing work. Simple data entry is so mindless.

* [take a break] -> Break
* [Keep Working] -> Working

=== Break===
It also is somehow so energy consuming. Maybe I could go to the break room kitchen and grab something to eat?

-> DONE

=== Working ===
But I have no time to take a break. Work keeps the brain busy.

-> CoworkerStart

=== CoworkerStart===
#speaker: Dillon #portrait: Laid_Back
Hey Matty, how you going?

* [Hi Dillon, I'm good, how are you?] -> coworker_interaction
* [I'm working.] -> CheerUp

=== CheerUp ===
Oh come on, I'm just trying to have a bit of a conversation. Didn't see you on break so I thought to just check on you.

* [Thank you,] -> bar
* [I'm kinda busy...] 
    Aw, you're no fun. -> bar
* [*Say nothing*] -> awkward

=== bar ===
Anyway. I was going to ask if you wanted to go to the bar after this.

* [sure] -> sure
* [no thank you] -> okay

=== coworker_interaction ===
I'm pretty good. Just the same old thing.
But hey, how's it going with your partner? Still mad at you?

* [Not yet] -> continue
* [I don't know] -> continue

=== continue ===
Eh, they’ll get over it eventually. Not your fault that you just need the time to get ready, y’know? 
If they were half as understanding, they’d give you the time to recover and get back to it when you’re ready. Isn’t that what love is?

* [I guess...] -> thats_the_spirit
* [*Say nothing*] -> awkward

=== thats_the_spirit ===
Thats the spirit. Hey, I got an idea that might cheer you up, why not get a drink after this? 
The bar’s close and you look like you need to loosen up. And you owe me a drink anyway so perfect opportunity.

* [I dont know...] -> okay
* [Sure] -> sure

=== awkward ===
... oooookay then.

Actually, I got an idea that might cheer you up, why not get a drink after this?
The bar’s close and you look like you need to loosen up. And you owe me a drink anyway so perfect opportunity.
What do you say?

* [I dont know...] -> okay
* [Sure] -> sure

=== sure ===
Alrighty then, see you then!

-> DONE

=== okay ===
Well, invites still open if you want it. We should probably get back to work soon.

-> DONE