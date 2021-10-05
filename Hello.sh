echo Hello
echo World

msg="Hello World"

echo $msg

echo What is your name?
read userInput
echo Hello $userInput, "Welcome to Programming!"

# Control Flow
# Types of loops
# For loop - They will repeat something a set number of times
for var in 1 2 3 4 5 6 7  
do
	echo $var
	echo This variable currently holds: $var
done

for words in My name is Oscar
do
	echo $words
done

#while loops - they will repeat something until the condition isn't satisfied anymore
condition="true"

while [ "$condition" != "false" ]
do
	echo "Do you want to repeat?? (true or false)" 
	read condition 
	echo "you typed: $condition"
done

# If Statements
echo -n "Enter a number: "
read VAR

if [[ $VAR -gt 10 ]]
then
echo "The variable is greater than 10."
fi
