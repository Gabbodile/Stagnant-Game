INCLUDE GlobalFunction.ink
Sup? #speaker: Dillon #portrait: Laid_Back

* [Can you get me a snack?] -> snack
* [How are you going?] -> coworker_interaction

===snack===
You forgot your wallet again? 

* [Yeah] -> no_wallet
* [No] -> Wallet

=== no_wallet ===
- Sigh - okay then Matty boy, but you owe me a drink.

* [How are you?] -> coworker_interaction

=== Wallet ===
Well, you can go get your own snack.

* [How are you?] -> coworker_interaction

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

