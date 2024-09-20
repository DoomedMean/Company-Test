#Get user input
user_input = input("Please input string: ")

#Reverse char
reversed_char_input = "".join([char for char in user_input if char.isalpha()][::-1])

#get_number
number = "".join([char for char in user_input if char.isdigit()])

#combine
result = reversed_char_input + number

print(f"Result : {result}")