import keyboard

input_array = [] 
query_array = []
result = []

#Append user input to array
def append(array, is_input_array:bool):
    while True:
        key = keyboard.read_event()

        if key.event_type == keyboard.KEY_DOWN:
            if key.name == "esc":
                break
            else:
                index = input()
                if not is_input_array and index in array:
                    print(f"{index} already exist on query array")
                else:
                    array.append(index)

#Check total occurrence of query in input array
def check(input_array, query_array):
    for word in query_array:
        count = int(0)
        for item in input_array:
            if word == item:
                count += 1
        result.append(count)

print("Please input array (Esc for quit array, Enter for new index):")
append(input_array, True)
print("\nPlease query array (Esc for quit array, Enter for new index):")
append(query_array, False)

check(input_array,query_array)
print("\nResult:")

for i in range(len(query_array)):
    print(f'{query_array[i]} : {result[i]}')