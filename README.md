# human

 Create a Human class with five public fields: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
 Add an additional private field for health (int), and a public property to access or "get" health
 Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
 Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
 Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
