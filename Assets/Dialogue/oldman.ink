EXTERNAL logEvent(eventLog)

Hello can you Help Me with Laundry?
 ~ logEvent("Agreed_Laundry")
 * Yes ->yes
 * No ->no
 
===yes===
 -Oh Thank you so much! talk to pie, he has the Key to that door
 ~ logEvent("Agreed_Laundry")
 ->END
 
===no===
Oh ok
->END
